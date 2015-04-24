namespace SharpPhone
{
    partial class Phone
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
            this.screenPanel = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // screenPanel
            // 
            this.screenPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.screenPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screenPanel.Location = new System.Drawing.Point(12, 12);
            this.screenPanel.Name = "screenPanel";
            this.screenPanel.Size = new System.Drawing.Size(391, 381);
            this.screenPanel.TabIndex = 0;
            this.screenPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(169, 397);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 46);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // Phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(415, 446);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.screenPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Phone";
            this.Text = "SharpPhone";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screenPanel;
        private System.Windows.Forms.Button homeButton;
    }
}

