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

        private static SpreadsheetController ssCtrl = new SpreadsheetController();
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

        //Handle mouse down when the user click on the cell
        private static void HandleMouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ssCtrl.HandleMouseRequest();
            }
        }

        //Handle mouse up when the user click on the cell
        private static void HandleMouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                sssCtrl.CancelMouseRequest();
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

            //// Open the connection prompt
            //ConnectionPrompt popup = new ConnectionPrompt();
            //Application.Run(popup);

            //// Capture the result
            //string IPaddress = popup.getIPAddress();
            //string userName = popup.getUserName();

            //popup.Dispose();

            //// Prompt window was closed
            //if (IPaddress == "")
            //    return;

           

            //// Prompt user input
            //SelectionPrompt selPmt = new SelectionPrompt(ssCtrl, IPaddress, userName);
            //if(!selPmt.errorOccured)
            //Application.Run(selPmt);

            //// Capture the result
            //string ssName = selPmt.selection;

            //selPmt.Dispose();

            //// Seleciton window was closed
            //if (selPmt.selection == "")
            //    return;

            // Open a spreadsheet form
            // SpreadsheetForm ssForm = new SpreadsheetForm(ssCtrl, ssName);
            SpreadsheetForm ssForm = new SpreadsheetForm(ssCtrl, "testing");
            appContext.RunForm(ssForm);
            Application.Run(appContext);
        }
    }
}
