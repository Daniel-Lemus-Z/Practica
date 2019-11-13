using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Los_Parámetros
{
    public class PasoPorValor
    {
        public static void PruebaPV(int numero)
        {
            numero = numero + 20;
            Console.WriteLine("Resultado de la suma: " + numero);
        }
    }
}
