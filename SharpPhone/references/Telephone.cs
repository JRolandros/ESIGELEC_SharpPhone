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

       /**
        * Implementation des methodes de IHistoriqueAppel
        * */
       public void afficherTousAppels()
       {
           Console.WriteLine("telephone classe!");
       }

       public void infoAppel(Appel appel)
       {

       }
       public void afficherAppelsRecus()
       {

       }
       public void afficherAppelsEmis()
       {

       }
       public void afficherAppelsManques()
       {

       }

       /**
        * Implementation de l'interface IGestionContact
        * */
       public void afficherTousContacts()
       {

       }
       public void supprimerContact(Contact contact)
       {

       }
       public void editerContact(Contact contact)
       {

       }
       public void afficherContact(string numTelephone)
       {

       }
        /**
         * Implementation de l'interface IAppel
         * */
       public void lancerAppel(string numDestinataire)
       {

       }
       public void composerNumero(int chiffre)
       {

       }

        /**
          * Implementation de l'interface IMessage
          * */
       public void afficheSMSContact(Contact contact)
       {

       }
       public void ecrireSMS(string numDestinataire, string message)
       {

       }
       public void supprimerSMS(SMS sms)
       {

       }
       public void afficherListePersonnesContactees()
       {

       }
    }
}
