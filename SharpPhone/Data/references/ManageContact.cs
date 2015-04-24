using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpPhone.references;
//using SharpPhone.Data.references;

namespace SharpPhone.Data.references
{
    public class ManageContact
    {
       /// <summary>
       /// instance de l'objet bdd qui permet de récupérer les tables de la bdd
       /// </summary>
        Bdd_SharpPhoneEntities _entities = new Bdd_SharpPhoneEntities();

        /// <summary>
        /// return all the entries in database table T_contact
        /// </summary>
        /// <returns></returns>
        private List<T_contact> SelectAllTContact()
        {
            return _entities.T_contact.ToList();
        }
        /// <summary>
        /// permet de transformer les tables sql en objets C#
        /// </summary>
        /// <param name="contacts"></param>
        /// <returns></returns>
        private List<Contact> Convert_TContact_ToContact(List<T_contact> contacts)
        {
            List<Contact> listContacts = new List<Contact>();
             return   contacts.Select(unContact => new Contact(unContact.contact_nom, unContact.contact_prenom, unContact.contact_numTelephone)).ToList();
        }
        public List<Contact> SelectAllContacts()
        {
            return Convert_TContact_ToContact(SelectAllTContact());
        }
    }
}
