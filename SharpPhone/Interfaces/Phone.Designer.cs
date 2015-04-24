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
            this.mainBar = new System.Windows.Forms.Panel();
            this.clockText = new System.Windows.Forms.Label();
            this.batIcon = new System.Windows.Forms.PictureBox();
            this.netIcon = new System.Windows.Forms.PictureBox();
            this.PhoneOperator = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.screenPanel.SuspendLayout();
            this.mainBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // screenPanel
            // 
            this.screenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.screenPanel.BackgroundImage = global::SharpPhone.Properties.Resources.background;
            this.screenPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screenPanel.Controls.Add(this.mainBar);
            this.screenPanel.Location = new System.Drawing.Point(12, 12);
            this.screenPanel.Name = "screenPanel";
            this.screenPanel.Size = new System.Drawing.Size(359, 595);
            this.screenPanel.TabIndex = 0;
            // 
            // mainBar
            // 
            this.mainBar.BackColor = System.Drawing.Color.Black;
            this.mainBar.Controls.Add(this.clockText);
            this.mainBar.Controls.Add(this.batIcon);
            this.mainBar.Controls.Add(this.netIcon);
            this.mainBar.Controls.Add(this.PhoneOperator);
            this.mainBar.Location = new System.Drawing.Point(-2, -2);
            this.mainBar.Name = "mainBar";
            this.mainBar.Size = new System.Drawing.Size(391, 23);
            this.mainBar.TabIndex = 0;
            // 
            // clockText
            // 
            this.clockText.AutoSize = true;
            this.clockText.BackColor = System.Drawing.Color.Transparent;
            this.clockText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockText.ForeColor = System.Drawing.Color.White;
            this.clockText.Location = new System.Drawing.Point(159, 6);
            this.clockText.Name = "clockText";
            this.clockText.Size = new System.Drawing.Size(39, 13);
            this.clockText.TabIndex = 1;
            this.clockText.Text = "13:38";
            // 
            // batIcon
            // 
            this.batIcon.Image = global::SharpPhone.Properties.Resources.batteryphone;
            this.batIcon.Location = new System.Drawing.Point(318, 3);
            this.batIcon.Name = "batIcon";
            this.batIcon.Size = new System.Drawing.Size(33, 20);
            this.batIcon.TabIndex = 2;
            this.batIcon.TabStop = false;
            // 
            // netIcon
            // 
            this.netIcon.Image = global::SharpPhone.Properties.Resources.networkphone;
            this.netIcon.Location = new System.Drawing.Point(5, 3);
            this.netIcon.Name = "netIcon";
            this.netIcon.Size = new System.Drawing.Size(24, 17);
            this.netIcon.TabIndex = 1;
            this.netIcon.TabStop = false;
            // 
            // PhoneOperator
            // 
            this.PhoneOperator.AutoSize = true;
            this.PhoneOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneOperator.ForeColor = System.Drawing.Color.White;
            this.PhoneOperator.Location = new System.Drawing.Point(30, 4);
            this.PhoneOperator.Name = "PhoneOperator";
            this.PhoneOperator.Size = new System.Drawing.Size(71, 15);
            this.PhoneOperator.TabIndex = 1;
            this.PhoneOperator.Text = "Operateur";
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.Image = global::SharpPhone.Properties.Resources.HomeButton1;
            this.homeButton.Location = new System.Drawing.Point(136, 608);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(112, 90);
            this.homeButton.TabIndex = 1;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // Phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::SharpPhone.Properties.Resources.PhoneFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(383, 710);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.screenPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Phone";
            this.Text = "SharpPhone";
            this.screenPanel.ResumeLayout(false);
            this.mainBar.ResumeLayout(false);
            this.mainBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screenPanel;
        private System.Windows.Forms.Panel mainBar;
        private System.Windows.Forms.Label PhoneOperator;
        private System.Windows.Forms.PictureBox batIcon;
        private System.Windows.Forms.PictureBox netIcon;
        private System.Windows.Forms.Label clockText;
        private System.Windows.Forms.PictureBox homeButton;
    }
}

