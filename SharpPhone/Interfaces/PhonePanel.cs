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
        private Phone parentPhone = null;

        public PhonePanel(Phone parent)
        {
            //Initialisation du panel
            InitializeComponent();

            //Création d'un lien entre le téléphone et l'écran
            this.parentPhone = parent;
        }

        //Gestion des buttons du téléphone
        private void keyboardControl(object sender, EventArgs e)
        {
            Button pressedBut = (Button)sender; //Récupération du boutton générateur de l'évenement

            //On control si on appuie sur les bouttons de début ou de fin de communication
            if (pressedBut.Text == "")
            {
                if(pressedBut == this.buttonSend)
                {
                    //Traitement pour l'envoie d'un appel
                }
                else
                {
                    //Traitement pour la cloture d'un appel
                }

            }
            else if (textNum.Text.Length < 10)
                this.textNum.Text += pressedBut.Text;
        }

        //Fonction de controle 
    }
}
