﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Capítulo_19
{
    public class ConsultasParalelas
    {
        //Durante la ejecución, la consulta se  ejecuta a través de varias tareas. 
        //La lista se divide en varias partes, de manera que cada una de ella se gestiona con  una tarea para tratar la cláusula where. 
        //Después del tratamiento, la lista se vuelve a unir para hacer el cálculo de la  media de los elementos restantes. 
        public static void CalcularValorMedio()
        {
            int size = 400_000_000;
            List<int> list = new List<int>(size);
            Random random = new Random();
           
            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(20));
            }


            var valorMedio = (from l in list.AsParallel()
                              where l > 10
                              select l).Average();


            Console.WriteLine(valorMedio);

            valorMedio = (from l in list
                              where l > 10
                              select l).Average();


            Console.WriteLine(valorMedio);


            double avg = list.AsParallel()
                .Where(i => i > 10).Average();

        }

        public static void ParticionarUnaConsulta()
        {
            int size = 400_000_000;
            List<int> list = new List<int>(size);
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(20));
            }

            //El método estático Create recibe como argumento un array o un objeto que implementa la interfaz IList<T>.  
            //Éste permite influir en el paralelismo de la consulta.
            double valorMedio = (from l in Partitioner.Create(list, true)
                                                      .AsParallel()
                                                      .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                                                      .WithDegreeOfParallelism(4)
                                                      .WithMergeOptions(ParallelMergeOptions.AutoBuffered)
                                 where l > 10
                                 select l).Average();

            Console.WriteLine(valorMedio);
                
        }

        //La consulta se ejecuta en una tarea separada, que devuelve un error de tipo OperationCancelException  cuando la consulta se anula. 
        //A partir de la tarea principal, la consulta se puede anular invocando al método Cancel  del objeto CancellationTokenSource.
        public static void AnularConsulta()
        {
            int size = 400_000_000;
            List<int> list = new List<int>(size);
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(20));
            }

            CancellationTokenSource ct = new CancellationTokenSource();
            Thread h = new Thread(
                () =>
                {
                    try
                    {
                        double valorMedio = (from l in Partitioner.Create(list, true)
                                                                  .AsParallel()
                                                                  .WithCancellation(ct.Token)
                                             where l > 10
                                             select l).Average();
                    }
                    catch (OperationCanceledException ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                });

            h.Start();
            Thread.Sleep(3000);
            ct.Cancel();
        }

    }
}
