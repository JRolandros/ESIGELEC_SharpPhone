using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPhone.references
{
    public interface IGestionContact
    {
        public void afficherTousContacts();
        public void supprimerContact(Contact contact);
        public void editerContact(Contact contact);
        public void afficherContact(string numTelephone);
    }
}
