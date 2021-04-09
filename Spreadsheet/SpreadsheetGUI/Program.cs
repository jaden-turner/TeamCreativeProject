using Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpreadsheetGUI
{
    static class Program
    {
        /// <summary>
        /// Keeps track of how many top-level forms are running
        /// </summary>
        public class DemoApplicationContext : ApplicationContext
        {
            // Number of open forms
            private int formCount = 0;

            // Singleton ApplicationContext
            private static DemoApplicationContext appContext;

            /// <summary>
            /// Private constructor for singleton pattern
            /// </summary>
            private DemoApplicationContext()
            {
            }

            /// <summary>
            /// Returns the one DemoApplicationContext.
            /// </summary>
            public static DemoApplicationContext getAppContext()
            {
                if (appContext == null)
                {
                    appContext = new DemoApplicationContext();
                }
                return appContext;
            }

            /// <summary>
            /// Runs the form
            /// </summary>
            public void RunForm(Form form)
            {

                // One more form is running
                formCount++;

                // When this form closes, we want to find out
                form.FormClosed += (o, e) => { if (--formCount <= 0) ExitThread(); };

                // Run the form
                form.Show();
            }

        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start an application context and run one form inside it
            DemoApplicationContext appContext = DemoApplicationContext.getAppContext();
            //appContext.RunForm(new Spreadsheet());

            // Open the connection prompt
            ConnectionPrompt popup = new ConnectionPrompt();
            Application.Run(popup);

            // Capture the result
            string IPaddress = popup.getIPAddress();
            string userName = popup.getUserName();

            if (IPaddress == "")
                return;

            // Open connection with server
            SpreadsheetController ssCtrl = new SpreadsheetController();
            
            // TODO:
            // Open display of available spreadsheets
            // Prompt user input

            // Open a spreadsheet form
            SpreadsheetForm ssForm = new SpreadsheetForm(ssCtrl);
            appContext.RunForm(ssForm);
            Application.Run(appContext);
        }
    }
}
