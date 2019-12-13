using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Capítulo_7.Program;

namespace Capítulo_7.Delegados.Compatibilidad_de_los_delegados
{
    public class Clase1CD
    {
        public Clase1CD(string s1, string s2)
        {
            Concatenar1 C1 = Concatenados;
            string resultado1 = C1(s1, s2);

            Concatenar2 C2 = Concatenados;
            string resultado2 = (string)C2(s1, s2);

        }

        public string Concatenados(object o1, object o2)
        {
            return (string)o1 + (string)o2;
        }
            
        public string Concatenados(string s1, string s2)
        {
            return s1 + s2;
        }
    }
}
