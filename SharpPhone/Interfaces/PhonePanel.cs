using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpPhone.Interfaces
{
    public partial class PhonePanel : UserControl
    {
        public PhonePanel()
        {
            InitializeComponent();
        }

        //Gestion des buttons du téléphone

        private void button1_Click(object sender, EventArgs e)
        {
            this.textNum.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textNum.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textNum.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textNum.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textNum.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textNum.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textNum.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textNum.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textNum.Text += 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.textNum.Text += 0;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }

        //Fonction de controle 
    }
}
