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
        public SettingPanel()
        {
            InitializeComponent();
            //this.TextTelNumber.Text = ((Phone)this.ParentForm).phoneNumber; //Récupération du numéro de téléphone
        }
    }
}
