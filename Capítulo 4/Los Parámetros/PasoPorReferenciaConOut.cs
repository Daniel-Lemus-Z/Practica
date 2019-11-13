using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Los_Parámetros
{
    public class PasoPorReferenciaConOut
    {
        public static void PruebaPROut(out int numero)
        {
            numero = 2019;
            Console.WriteLine("Paso con Out: " + numero);
        }

        public static void prueba(out string s1, out string s2)
        {
            s1 = "prueba1";
            s2 = "prueba2";

            Console.WriteLine(s1 + " " + s2);
        }
    }
}
