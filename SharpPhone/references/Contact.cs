using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPhone.references
{
   public class Contact
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        private string numTelephone;
        public string NumTelephone { 
            get; 
           private set {
                System.Text.RegularExpressions.Regex myRegex = new System.Text.RegularExpressions.Regex(@"(^06[0-9]{8}$|^00[0-9]{11,13}$)");
                if (myRegex.IsMatch(value))
                    numTelephone = value;
            } 
        }

        public Contact(string nom, string prenom, string numTelephone)
        {
                
            this.nom = nom;
            this.prenom = prenom;
            this.NumTelephone = numTelephone;
        }


    }
}
