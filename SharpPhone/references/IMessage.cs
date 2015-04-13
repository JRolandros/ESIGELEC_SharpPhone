using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPhone.references
{
    public interface IMessage
    {
        void afficheSMSContact(Contact contact);
        void ecrireSMS(string numDestinataire, string message);
        void supprimerSMS(SMS sms);
        void afficherListePersonnesContactees();
    }
}
