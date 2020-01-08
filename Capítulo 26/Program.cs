using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Capítulo_26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hilos

            ThreadExamples.CreateThread();

            ThreadExamples.CancelThread();

            ThreadExamples.ExchangeDataType1();

            ThreadExamples.ExchangeDataType2();

            ThreadExamples.ExchangeDataType3();

            ThreadExamples.BlockThread();

            ThreadExamples.PriorityThread();


            //Funciones Asincronas

            Console.WriteLine("Ejecución de una función larga asíncrona");
            int i = 0;
            Task<double> task = AsyncFunctions.TimeConsumingFunctionAsync();
            TaskAwaiter<double> awaiter = task.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                i = 20;
                double resultado2 = awaiter.GetResult();
                Console.Write("Resultado: ");
                Console.WriteLine(resultado2);
            });
            for (i = 1; i < 15; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }



            Console.WriteLine("Ejecución asíncrona en una iteración");
            AsyncFunctions.Iteration();
            for (int j = 1; j < 20; j++)
            {
                Console.WriteLine(j);
                Thread.Sleep(1000);
            }








            Console.ReadKey();

            
        }

       


       
     
    }
}
