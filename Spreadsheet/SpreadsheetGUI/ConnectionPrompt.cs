using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpreadsheetGUI
{
    public partial class ConnectionPrompt : Form
    {
        public string IPaddress = "";
        public string userName = "";

        public ConnectionPrompt()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When both text boxes have some text, enable the connection
        /// button.
        /// </summary>
        private void IPtextBox_TextChanged(object sender, EventArgs e)
        {
            if (IPtextBox.TextLength > 0 && NameTextBox.TextLength > 0)
                connectButton.Enabled = true;

            else
                connectButton.Enabled = false;
        }

        /// <summary>
        /// Forwards info to other eventHandler
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            IPtextBox_TextChanged(sender, e);
        }

        /// <summary>
        /// Submits the user's inputs
        /// </summary>
        private void connectButton_Click(object sender, EventArgs e)
        {
            // Only allow connection once.
            connectButton.Enabled = false;
            IPtextBox.Enabled = false;
            NameTextBox.Enabled = false;

            IPaddress = IPtextBox.Text;
            userName = NameTextBox.Text;

            this.Close();
        }

        public string getIPAddress()
        {
            return IPaddress;
        }

        public string getUserName()
        {
            return userName;
        }
    }
}
