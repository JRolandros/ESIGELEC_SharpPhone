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
        public HomePanel()
        {
            InitializeComponent();
        }

        private void phoneIcoClick(object sender, EventArgs e)
        {
            //Changement de l'écran en écran Téléphone
            ((Phone)this.ParentForm).changeInterface("Phone");
        }

        private void smsIcoClick(object sender, EventArgs e)
        {
            //Changement de l'écran en écran Téléphone
            ((Phone)this.ParentForm).changeInterface("SMS");
        }

        private void historyIcoClick(object sender, EventArgs e)
        {
            //Changement de l'écran en écran Téléphone
            ((Phone)this.ParentForm).changeInterface("Historic");
        }

        private void contactIcoClick(object sender, EventArgs e)
        {
            //Changement de l'écran en écran Téléphone
            ((Phone)this.ParentForm).changeInterface("Contact");
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
