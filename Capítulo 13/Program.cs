using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Error de ejecución
            //int i = 0;
            //int j = 10 / i;


            //Condición de parada
            int h = 0;
            for (int p = 0; p < 10; p++)
            {
                Console.WriteLine("Inicial:" + h);
                if (p%2==0)
                {
                    h++;
                }
                Console.WriteLine("Final:" + h);
            }

            Filename.Run();
            Filename.CallerDetected();


            Console.ReadLine();

    
        }
    }
}
