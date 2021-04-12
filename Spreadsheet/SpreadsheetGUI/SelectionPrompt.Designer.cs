namespace SpreadsheetGUI
{
    partial class SelectionPrompt
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
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.SelectionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SpreadsheetNamesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(146, 311);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(349, 31);
            this.userInputTextBox.TabIndex = 0;
            this.userInputTextBox.TextChanged += new System.EventHandler(this.userInputTextBox_TextChanged);
            // 
            // SelectionButton
            // 
            this.SelectionButton.Enabled = false;
            this.SelectionButton.Location = new System.Drawing.Point(516, 311);
            this.SelectionButton.Name = "SelectionButton";
            this.SelectionButton.Size = new System.Drawing.Size(96, 31);
            this.SelectionButton.TabIndex = 1;
            this.SelectionButton.Text = "Select";
            this.SelectionButton.UseVisualStyleBackColor = true;
            this.SelectionButton.Click += new System.EventHandler(this.SelectionButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(146, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available Spreadsheets:\r\n";
            // 
            // SpreadsheetNamesLabel
            // 
            this.SpreadsheetNamesLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SpreadsheetNamesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SpreadsheetNamesLabel.Location = new System.Drawing.Point(146, 63);
            this.SpreadsheetNamesLabel.Name = "SpreadsheetNamesLabel";
            this.SpreadsheetNamesLabel.Size = new System.Drawing.Size(466, 221);
            this.SpreadsheetNamesLabel.TabIndex = 3;
            // 
            // SelectoionPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpreadsheetNamesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectionButton);
            this.Controls.Add(this.userInputTextBox);
            this.Name = "SelectoionPrompt";
            this.Text = "SelectorPrompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Button SelectionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SpreadsheetNamesLabel;
    }
}