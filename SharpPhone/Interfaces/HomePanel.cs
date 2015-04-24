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
    public partial class HomePanel : UserControl
    {
        private Phone parentPhone = null;

        public HomePanel(Phone parent)
        {
            //Initialisation du panel
            InitializeComponent();

            //Création d'un lien entre le téléphone et l'écran
            this.parentPhone = parent;
        }

        private void phoneIcoClick(object sender, EventArgs e)
        {
            //Changement de l'écran en écran Téléphone
            this.parentPhone.changeInterface("Phone");
        }

        private void smsIcoClick(object sender, EventArgs e)
        {
            //Changement de l'écran en écran Téléphone
            this.parentPhone.changeInterface("SMS");
        }

        private void historyIcoClick(object sender, EventArgs e)
        {
            //Changement de l'écran en écran Téléphone
            this.parentPhone.changeInterface("Historic");
        }

        private void contactIcoClick(object sender, EventArgs e)
        {
            //Changement de l'écran en écran Téléphone
            this.parentPhone.changeInterface("Contact");
        }

        private void exitIcoClick(object sender, EventArgs e)
        {
            //Fermeture de l'application
            Application.Exit();
        }

        private void ParamIcoClick(object sender, EventArgs e)
        {
            //Changement de l'écran en écran de paramètres
            ((Phone)this.ParentForm).changeInterface("Settings");
        }
    }
}
