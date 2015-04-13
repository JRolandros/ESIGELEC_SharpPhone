using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPhone.references
{
    public interface IAppel
    {
        void lancerAppel(string numDestinataire);
        void composerNumero(int chiffre);

    }
}
