using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPhone.references
{
   public class Telephone: IGestionContact,IHistoriqueAppel,IAppel,IMessage
    {
       public string numTelephone { get; set;}
       public string operateur { get; set; }
       public string sonnerie { get; set; }

       public Telephone(string operateur, string numTelephone)
       {
           this.numTelephone = numTelephone;
           this.operateur = operateur;
       }
       public void changerOperateur(string operateur)
       {

       }

    }
}
