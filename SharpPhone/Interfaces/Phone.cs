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

using SharpPhone.Interfaces;

namespace SharpPhone
{
    public partial class Phone : Form
    {
        public UserControl screen { get; set; } //Ecran du téléphone
        public String phoneNumber { get; set; } //Numéro de téléphone de l'appareil
        public String phoneRingtone { get; set; } //Nom de la sonnerie du téléphone

        public Phone()
        {
            InitializeComponent();

            //Initialisation du panel d'accueil
            this.screen = new HomePanel(this);
            this.screenPanel.Controls.Add(screen);

            //Initialisation du numéro de téléphone
            this.phoneNumber = "";
            this.phoneRingtone = "";
            this.PhoneOperator.Text = "Inconnu";
        }

        /*
         * Fonction qui permet le passage entre les différentes interfaces.
         */
        public void changeInterface(String panelName)
        {
            //Fermeture de panel précédent
            this.screen.Dispose();

            //Ouverture de la nouvelle fenêtre
            switch (panelName)
            {
                case "Historic":
                    this.screen = new AppelHistory(this);
                break;

                case "SMS":
                    this.screen = new SMSPanel(this);
                break;

                case "Phone":
                    this.screen = new PhonePanel(this);
                break;

                case "Contact":
                    this.screen = new ContactPanel(this);
                break;

                case "Settings":
                    this.screen = new SettingPanel(this);
                break;

                default:
					this.screen = new HomePanel(this);
                break;
            }

            //On positionne l'écran sur le panel
            this.screenPanel.Controls.Add(screen);
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            //Retour vers l'écran d'accueil
            this.changeInterface("Home");
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            ManageContact m = new ManageContact();
            MessageBox.Show(m.SelectAllContacts().ElementAt(0).nom);
        }
    }
}
