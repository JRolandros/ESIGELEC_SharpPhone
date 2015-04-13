using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPhone.references
{
    public interface IGestionContact
    {
        void afficherTousContacts();
        void supprimerContact(Contact contact);
        void editerContact(Contact contact);
        void afficherContact(string numTelephone);
    }
}
