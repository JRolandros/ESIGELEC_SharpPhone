namespace SharpPhone.Interfaces
{
    partial class SettingPanel
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
            this.groupTel = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelSonnerie = new System.Windows.Forms.Label();
            this.TextTelNumber = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.groupTel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTel
            // 
            this.groupTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupTel.Controls.Add(this.comboBox1);
            this.groupTel.Controls.Add(this.labelSonnerie);
            this.groupTel.Controls.Add(this.TextTelNumber);
            this.groupTel.Controls.Add(this.labelTel);
            this.groupTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTel.ForeColor = System.Drawing.Color.White;
            this.groupTel.Location = new System.Drawing.Point(3, 30);
            this.groupTel.Name = "groupTel";
            this.groupTel.Size = new System.Drawing.Size(349, 160);
            this.groupTel.TabIndex = 0;
            this.groupTel.TabStop = false;
            this.groupTel.Text = "Paramètres du téléphone";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // labelSonnerie
            // 
            this.labelSonnerie.AutoSize = true;
            this.labelSonnerie.Location = new System.Drawing.Point(19, 75);
            this.labelSonnerie.Name = "labelSonnerie";
            this.labelSonnerie.Size = new System.Drawing.Size(69, 15);
            this.labelSonnerie.TabIndex = 2;
            this.labelSonnerie.Text = "Sonnerie:";
            // 
            // TextTelNumber
            // 
            this.TextTelNumber.Location = new System.Drawing.Point(124, 36);
            this.TextTelNumber.MaxLength = 10;
            this.TextTelNumber.Name = "TextTelNumber";
            this.TextTelNumber.Size = new System.Drawing.Size(208, 21);
            this.TextTelNumber.TabIndex = 1;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(19, 37);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(99, 15);
            this.labelTel.TabIndex = 0;
            this.labelTel.Text = "N° Téléphone:";
            // 
            // SettingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupTel);
            this.Name = "SettingPanel";
            this.Size = new System.Drawing.Size(355, 592);
            this.groupTel.ResumeLayout(false);
            this.groupTel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTel;
        private System.Windows.Forms.TextBox TextTelNumber;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelSonnerie;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}
