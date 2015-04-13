using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPhone.references
{
   public  class Appel : Communication
    {
       public int duree { get; set; }
       public Boolean manque { get; }

       public Appel(string numEmetteur, string numDestinataire)
           : base(numEmetteur, numDestinataire)
       {
       }
       public Appel(string numEmetteur, string numDestinataire, DateTime date)
           : base(numEmetteur, numDestinataire, date)
       {
       }
    }
}
