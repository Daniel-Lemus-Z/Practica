using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_6.Interfaces_Genéricas.Covarianza_Y_Contravarianza
{
    public static class Program2
    {
        public static void Write (IEnumerable<Clase1> Elementos1)
        {
            foreach (Clase1 elem in Elementos1)
            {
                Console.WriteLine("{0} {1}" , elem.Prop1, elem.Prop2);
            }
        }
    }
}
