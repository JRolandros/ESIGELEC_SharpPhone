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
    public partial class AppelHistory : UserControl
    {
        private Phone parentPhone = null;

        public AppelHistory(Phone parent)
        {
            //Initialisation du panel
            InitializeComponent();

            //Création d'un lien entre le téléphone et l'écran
            this.parentPhone = parent;
        }

        private void AppelHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
