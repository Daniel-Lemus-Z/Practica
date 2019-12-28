using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_14
{
    class Program
    {
        //[Conditional("DEBUG")]
        static void Main(string[] args)
        {
            Trace.Assert(args.Length == 5, "Los argumentos están mal.");
            
            Debug.WriteLine("hola...");
            Trace.WriteLine("hola...");

            int[] a = new int[20];

            IntercepcionYGestionDeExcepciones I = new IntercepcionYGestionDeExcepciones();
            I.GetValueFromArray(a,23);
        }
    }
}
