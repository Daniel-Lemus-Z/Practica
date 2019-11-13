using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Los_Parámetros
{
    public class PasoPorReferenciaConRef
    {
        public static void PruebaPRRef(ref int numero)
        {
            numero = numero + 100;
            Console.WriteLine("El resultado de la suma es: " + numero);
        }
    }
}
