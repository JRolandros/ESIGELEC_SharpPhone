using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SharpPhone.references
{
    public interface IMessage
    {
        public void afficheSMSContact( Contact contact);
        public void ecrireSMS(string numDestinataire, string message);
        public void supprimerSMS(SMS sms);
        public void afficherListePersonnesContactees();
    }
}
