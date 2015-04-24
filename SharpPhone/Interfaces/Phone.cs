using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpPhone.Data.references;

namespace SharpPhone
{
    public partial class Phone : Form
    {
        public Phone()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            ManageContact m = new ManageContact();
            MessageBox.Show(m.SelectAllContacts().ElementAt(0).nom);
        }
    }
}
