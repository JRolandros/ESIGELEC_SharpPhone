using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPhone.references
{
    public interface IAppel
    {
        public void lancerAppel(string numDestinataire);
        public void composerNumero(int chiffre);

    }
}
