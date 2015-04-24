namespace SharpPhone.Interfaces
{
    partial class SMSPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.messageField = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.listeSMS = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // messageField
            // 
            this.messageField.Location = new System.Drawing.Point(6, 563);
            this.messageField.Name = "messageField";
            this.messageField.Size = new System.Drawing.Size(280, 20);
            this.messageField.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(293, 562);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(59, 23);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Envoyer";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // listeSMS
            // 
            this.listeSMS.Location = new System.Drawing.Point(0, 23);
            this.listeSMS.Name = "listeSMS";
            this.listeSMS.Size = new System.Drawing.Size(355, 533);
            this.listeSMS.TabIndex = 2;
            // 
            // SMSPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.listeSMS);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageField);
            this.Name = "SMSPanel";
            this.Size = new System.Drawing.Size(355, 592);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageField;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Panel listeSMS;
    }
}
