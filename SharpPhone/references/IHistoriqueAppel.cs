using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPhone.references
{
   public interface IHistoriqueAppel
    {
        void afficherTousAppels();
       void infoAppel(Appel appel);
       void afficherAppelsRecus();
       void afficherAppelsEmis();
       void afficherAppelsManques();
    }
}
