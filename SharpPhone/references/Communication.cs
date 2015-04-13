using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPhone.references
{
    public abstract class Communication
    {
        public string numEmetteur { get; private set; }
        public DateTime date { get; set; }
        public string numDestinataire { get; private set; }

        public Communication(string numEmetteur, string numDestination)
        {
            this.numEmetteur = numEmetteur;
            this.numDestinataire = numDestinataire;
        }

        public Communication(string numEmetteur, string numDestinataire, DateTime date)
        {
            this.numEmetteur = numEmetteur;
            this.numDestinataire = numDestinataire;
            this.date = date;
        }

    }
}
