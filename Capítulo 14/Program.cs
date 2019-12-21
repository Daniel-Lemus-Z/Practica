using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];

            IntercepcionYGestionDeExcepciones I = new IntercepcionYGestionDeExcepciones();
            I.GetValueFromArray(a,23);
        }
    }
}
