using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Los_Parámetros
{
    public class Tuplas
    {
        public static (string nom1, string nom2) SeparaNombre(string nom)
        {
            return (nom.Split('-')[0],nom.Split('-')[1]);
        }
    }
}
