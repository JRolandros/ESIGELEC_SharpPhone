namespace SharpPhone.Interfaces
{
    partial class HomePanel
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
            this.labelIcoPhone = new System.Windows.Forms.Label();
            this.labelSMSIco = new System.Windows.Forms.Label();
            this.labelHistoricIco = new System.Windows.Forms.Label();
            this.labelContactIco = new System.Windows.Forms.Label();
            this.labelQuitIco = new System.Windows.Forms.Label();
            this.labelParam = new System.Windows.Forms.Label();
            this.Paramico = new System.Windows.Forms.PictureBox();
            this.Quitico = new System.Windows.Forms.PictureBox();
            this.Contactico = new System.Windows.Forms.PictureBox();
            this.Historyico = new System.Windows.Forms.PictureBox();
            this.SMSico = new System.Windows.Forms.PictureBox();
            this.PhoneIco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Paramico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quitico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contactico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Historyico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMSico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneIco)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIcoPhone
            // 
            this.labelIcoPhone.AutoSize = true;
            this.labelIcoPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIcoPhone.ForeColor = System.Drawing.Color.White;
            this.labelIcoPhone.Location = new System.Drawing.Point(25, 117);
            this.labelIcoPhone.Name = "labelIcoPhone";
            this.labelIcoPhone.Size = new System.Drawing.Size(83, 16);
            this.labelIcoPhone.TabIndex = 5;
            this.labelIcoPhone.Text = "Téléphone";
            // 
            // labelSMSIco
            // 
            this.labelSMSIco.AutoSize = true;
            this.labelSMSIco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSMSIco.ForeColor = System.Drawing.Color.White;
            this.labelSMSIco.Location = new System.Drawing.Point(156, 117);
            this.labelSMSIco.Name = "labelSMSIco";
            this.labelSMSIco.Size = new System.Drawing.Size(40, 16);
            this.labelSMSIco.TabIndex = 6;
            this.labelSMSIco.Text = "SMS";
            // 
            // labelHistoricIco
            // 
            this.labelHistoricIco.AutoSize = true;
            this.labelHistoricIco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistoricIco.ForeColor = System.Drawing.Color.White;
            this.labelHistoricIco.Location = new System.Drawing.Point(242, 117);
            this.labelHistoricIco.Name = "labelHistoricIco";
            this.labelHistoricIco.Size = new System.Drawing.Size(79, 16);
            this.labelHistoricIco.TabIndex = 7;
            this.labelHistoricIco.Text = "Historique";
            // 
            // labelContactIco
            // 
            this.labelContactIco.AutoSize = true;
            this.labelContactIco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactIco.ForeColor = System.Drawing.Color.White;
            this.labelContactIco.Location = new System.Drawing.Point(39, 242);
            this.labelContactIco.Name = "labelContactIco";
            this.labelContactIco.Size = new System.Drawing.Size(60, 16);
            this.labelContactIco.TabIndex = 8;
            this.labelContactIco.Text = "Contact";
            // 
            // labelQuitIco
            // 
            this.labelQuitIco.AutoSize = true;
            this.labelQuitIco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuitIco.ForeColor = System.Drawing.Color.White;
            this.labelQuitIco.Location = new System.Drawing.Point(248, 566);
            this.labelQuitIco.Name = "labelQuitIco";
            this.labelQuitIco.Size = new System.Drawing.Size(66, 16);
            this.labelQuitIco.TabIndex = 9;
            this.labelQuitIco.Text = "Eteindre";
            // 
            // labelParam
            // 
            this.labelParam.AutoSize = true;
            this.labelParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParam.ForeColor = System.Drawing.Color.White;
            this.labelParam.Location = new System.Drawing.Point(133, 566);
            this.labelParam.Name = "labelParam";
            this.labelParam.Size = new System.Drawing.Size(88, 16);
            this.labelParam.TabIndex = 11;
            this.labelParam.Text = "Paramètres";
            // 
            // Paramico
            // 
            this.Paramico.Image = global::SharpPhone.Properties.Resources.SettingsIco;
            this.Paramico.Location = new System.Drawing.Point(136, 483);
            this.Paramico.Name = "Paramico";
            this.Paramico.Size = new System.Drawing.Size(80, 80);
            this.Paramico.TabIndex = 10;
            this.Paramico.TabStop = false;
            this.Paramico.Click += new System.EventHandler(this.ParamIcoClick);
            // 
            // Quitico
            // 
            this.Quitico.Image = global::SharpPhone.Properties.Resources.ExitIco;
            this.Quitico.Location = new System.Drawing.Point(241, 483);
            this.Quitico.Name = "Quitico";
            this.Quitico.Size = new System.Drawing.Size(80, 80);
            this.Quitico.TabIndex = 4;
            this.Quitico.TabStop = false;
            this.Quitico.Click += new System.EventHandler(this.exitIcoClick);
            // 
            // Contactico
            // 
            this.Contactico.Image = global::SharpPhone.Properties.Resources.contactIco;
            this.Contactico.Location = new System.Drawing.Point(28, 159);
            this.Contactico.Name = "Contactico";
            this.Contactico.Size = new System.Drawing.Size(80, 80);
            this.Contactico.TabIndex = 3;
            this.Contactico.TabStop = false;
            this.Contactico.Click += new System.EventHandler(this.contactIcoClick);
            // 
            // Historyico
            // 
            this.Historyico.Image = global::SharpPhone.Properties.Resources.HistoricIco;
            this.Historyico.Location = new System.Drawing.Point(241, 34);
            this.Historyico.Name = "Historyico";
            this.Historyico.Size = new System.Drawing.Size(80, 80);
            this.Historyico.TabIndex = 2;
            this.Historyico.TabStop = false;
            this.Historyico.Click += new System.EventHandler(this.historyIcoClick);
            // 
            // SMSico
            // 
            this.SMSico.Image = global::SharpPhone.Properties.Resources.SMSIco;
            this.SMSico.Location = new System.Drawing.Point(136, 34);
            this.SMSico.Name = "SMSico";
            this.SMSico.Size = new System.Drawing.Size(80, 80);
            this.SMSico.TabIndex = 1;
            this.SMSico.TabStop = false;
            this.SMSico.Click += new System.EventHandler(this.smsIcoClick);
            // 
            // PhoneIco
            // 
            this.PhoneIco.Image = global::SharpPhone.Properties.Resources.phoneIco;
            this.PhoneIco.Location = new System.Drawing.Point(28, 34);
            this.PhoneIco.Name = "PhoneIco";
            this.PhoneIco.Size = new System.Drawing.Size(80, 80);
            this.PhoneIco.TabIndex = 0;
            this.PhoneIco.TabStop = false;
            this.PhoneIco.Click += new System.EventHandler(this.phoneIcoClick);
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelParam);
            this.Controls.Add(this.Paramico);
            this.Controls.Add(this.labelQuitIco);
            this.Controls.Add(this.labelContactIco);
            this.Controls.Add(this.labelHistoricIco);
            this.Controls.Add(this.labelSMSIco);
            this.Controls.Add(this.labelIcoPhone);
            this.Controls.Add(this.Quitico);
            this.Controls.Add(this.Contactico);
            this.Controls.Add(this.Historyico);
            this.Controls.Add(this.SMSico);
            this.Controls.Add(this.PhoneIco);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(355, 592);
            ((System.ComponentModel.ISupportInitialize)(this.Paramico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quitico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contactico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Historyico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMSico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneIco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PhoneIco;
        private System.Windows.Forms.PictureBox SMSico;
        private System.Windows.Forms.PictureBox Historyico;
        private System.Windows.Forms.PictureBox Quitico;
        private System.Windows.Forms.PictureBox Contactico;
        private System.Windows.Forms.Label labelIcoPhone;
        private System.Windows.Forms.Label labelSMSIco;
        private System.Windows.Forms.Label labelHistoricIco;
        private System.Windows.Forms.Label labelContactIco;
        private System.Windows.Forms.Label labelQuitIco;
        private System.Windows.Forms.Label labelParam;
        private System.Windows.Forms.PictureBox Paramico;
    }
}
