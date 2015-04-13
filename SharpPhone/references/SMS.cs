using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPhone.references
{
   public class SMS : Communication
    {
       public string Sms
       {
           get;
           private set;
       }
        public SMS(string destinataire, string message,string emetteur) :base(destinataire,emetteur)
        {
            this.Sms = message;
        }

        public SMS(string destinataire, string message, string emetteur, DateTime date) :base(destinataire,emetteur,date)
        {
            this.Sms = message;
        }
    }
}
