namespace SharpPhone.Interfaces
{
    partial class AppelHistory
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
            this.tabAppelMissed = new System.Windows.Forms.TabPage();
            this.tabAppelsSend = new System.Windows.Forms.TabPage();
            this.tabAppelsRecieved = new System.Windows.Forms.TabPage();
            this.AppelCategoriesPanel = new System.Windows.Forms.TabControl();
            this.AppelCategoriesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAppelMissed
            // 
            this.tabAppelMissed.BackColor = System.Drawing.Color.Transparent;
            this.tabAppelMissed.Location = new System.Drawing.Point(4, 4);
            this.tabAppelMissed.Name = "tabAppelMissed";
            this.tabAppelMissed.Size = new System.Drawing.Size(383, 0);
            this.tabAppelMissed.TabIndex = 2;
            this.tabAppelMissed.Text = "Appels Manqués";
            // 
            // tabAppelsSend
            // 
            this.tabAppelsSend.BackColor = System.Drawing.Color.Transparent;
            this.tabAppelsSend.Location = new System.Drawing.Point(4, 4);
            this.tabAppelsSend.Name = "tabAppelsSend";
            this.tabAppelsSend.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppelsSend.Size = new System.Drawing.Size(383, 0);
            this.tabAppelsSend.TabIndex = 1;
            this.tabAppelsSend.Text = "Appels Emis";
            // 
            // tabAppelsRecieved
            // 
            this.tabAppelsRecieved.BackColor = System.Drawing.Color.Transparent;
            this.tabAppelsRecieved.Location = new System.Drawing.Point(4, 4);
            this.tabAppelsRecieved.Name = "tabAppelsRecieved";
            this.tabAppelsRecieved.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppelsRecieved.Size = new System.Drawing.Size(347, 0);
            this.tabAppelsRecieved.TabIndex = 0;
            this.tabAppelsRecieved.Text = "Appels Reçus";
            // 
            // AppelCategoriesPanel
            // 
            this.AppelCategoriesPanel.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.AppelCategoriesPanel.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.AppelCategoriesPanel.Controls.Add(this.tabAppelsRecieved);
            this.AppelCategoriesPanel.Controls.Add(this.tabAppelsSend);
            this.AppelCategoriesPanel.Controls.Add(this.tabAppelMissed);
            this.AppelCategoriesPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AppelCategoriesPanel.ItemSize = new System.Drawing.Size(114, 27);
            this.AppelCategoriesPanel.Location = new System.Drawing.Point(0, 23);
            this.AppelCategoriesPanel.Name = "AppelCategoriesPanel";
            this.AppelCategoriesPanel.Padding = new System.Drawing.Point(5, 4);
            this.AppelCategoriesPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AppelCategoriesPanel.SelectedIndex = 0;
            this.AppelCategoriesPanel.ShowToolTips = true;
            this.AppelCategoriesPanel.Size = new System.Drawing.Size(355, 569);
            this.AppelCategoriesPanel.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.AppelCategoriesPanel.TabIndex = 0;
            // 
            // AppelHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.AppelCategoriesPanel);
            this.Name = "AppelHistory";
            this.Size = new System.Drawing.Size(355, 592);
            this.Load += new System.EventHandler(this.AppelHistory_Load);
            this.AppelCategoriesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabAppelMissed;
        private System.Windows.Forms.TabPage tabAppelsSend;
        private System.Windows.Forms.TabPage tabAppelsRecieved;
        private System.Windows.Forms.TabControl AppelCategoriesPanel;

    }
}
