using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xBountyHunterShared.Models;

namespace xBountyHunterShared.Extras
{
    public class listaFugitivos
    {
        public List<mFugitivos> ocFugitivos;

        public listaFugitivos()
        {
            ocFugitivos = new List<mFugitivos>();
            ocFugitivos.Add(new mFugitivos
            {
                Name = "Armando Olmos"
            });
            ocFugitivos.Add(new mFugitivos
            {
                Name = "Carlos Martinez"
            });
            ocFugitivos.Add(new mFugitivos
            {
                Name = "Oscar Ruesga"
            });
            ocFugitivos.Add(new mFugitivos
            {
                Name = "Jorge Valadez"
            });
            ocFugitivos.Add(new mFugitivos
            {
                Name = "Guillermo Ortega"
            });
        }
    }
}
