namespace SpreadsheetGUI
{
    partial class ConnectionPrompt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IPtextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.IPLabel1 = new System.Windows.Forms.Label();
            this.IPLabel2 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IPtextBox
            // 
            this.IPtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPtextBox.Location = new System.Drawing.Point(265, 145);
            this.IPtextBox.Name = "IPtextBox";
            this.IPtextBox.Size = new System.Drawing.Size(384, 31);
            this.IPtextBox.TabIndex = 0;
            this.IPtextBox.TextChanged += new System.EventHandler(this.IPtextBox_TextChanged);
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(301, 242);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(116, 39);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // IPLabel1
            // 
            this.IPLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPLabel1.Location = new System.Drawing.Point(90, 49);
            this.IPLabel1.Name = "IPLabel1";
            this.IPLabel1.Size = new System.Drawing.Size(559, 65);
            this.IPLabel1.TabIndex = 4;
            this.IPLabel1.Text = "To connect to a spreadsheet server, input the server address below.";
            // 
            // IPLabel2
            // 
            this.IPLabel2.AutoSize = true;
            this.IPLabel2.Location = new System.Drawing.Point(90, 148);
            this.IPLabel2.Name = "IPLabel2";
            this.IPLabel2.Size = new System.Drawing.Size(166, 25);
            this.IPLabel2.TabIndex = 5;
            this.IPLabel2.Text = "Server Address:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(182, 194);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(74, 25);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(265, 194);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(384, 31);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // ConnectionPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 305);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IPLabel2);
            this.Controls.Add(this.IPLabel1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.IPtextBox);
            this.Name = "ConnectionPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection Prompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPtextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label IPLabel1;
        private System.Windows.Forms.Label IPLabel2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}