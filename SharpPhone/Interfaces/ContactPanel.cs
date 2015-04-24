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
    public partial class ContactPanel : UserControl
    {
        private Phone parentPhone = null;

        public ContactPanel(Phone parent)
        {
            //Initialisation du panel
            InitializeComponent();

            //Création d'un lien entre le téléphone et l'écran
            this.parentPhone = parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
