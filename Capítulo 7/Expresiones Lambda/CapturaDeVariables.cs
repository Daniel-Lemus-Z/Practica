using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_7.Expresiones_Lambda
{
    public class CapturaDeVariables
    {
        //Las  variables externas a las que se hace referencia en una expresión lambda se llaman variables capturadas   
        public static int Test1(int factor)
        {
            Func<int, int> multiplo = x => x * factor;
            return multiplo(10);
        }

        //Las variablescapturadas seevalúan cuandose invocael delegadoy nocuando sedefine laexpresión lambda
        public static int Test2(int factor)
        {
            Func<int, int> multiplo = x => x * factor; 
            factor = 3;
            return multiplo(10);
        }

        //Una variable local que se instancia en una expresión lambda es única por invocación del delegado
        public static Func<int> Añadir()
        {
            int i = 0;
            return () => i++;
        }

        public static void Test3()
        {
            Func<int> añadir = Añadir();
            int i1 = añadir();
            int i2 = añadir();
            int i3 = añadir();

            Console.WriteLine("1: " + i1);
            Console.WriteLine("2: " + i2);
            Console.WriteLine("3: " + i3);
        }

    }
}
