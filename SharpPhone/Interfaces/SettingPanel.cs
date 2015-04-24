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
    public partial class SettingPanel : UserControl
    {
        private Phone parentPhone = null;

        public SettingPanel(Phone parent)
        {
            //Initialisation du panel
            InitializeComponent();

            //Création d'un lien entre le téléphone et l'écran
            this.parentPhone = parent;

            //Récupération des informations
            this.TextTelNumber.Text = this.parentPhone.phoneNumber; //Récupération du numéro de téléphone
        }
    }
}
