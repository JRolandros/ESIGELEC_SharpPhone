using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPhone.references
{
   public interface IHistoriqueAppel
    {
       public void afficherTousAppels();
       public void infoAppel(Appel appel);
       public void afficherAppelsRecus();
       public void afficherAppelsEmis();
       public void afficherAppelsManques();
    }
}
