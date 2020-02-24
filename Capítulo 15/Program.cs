using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Capítulo_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.WriteLine("Inicio de la aplicación");
            Trace.Flush();

            int[] Numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                int Aleatorios = random.Next(0, 99);
                Numeros[i] = Aleatorios;
                Console.WriteLine(Numeros[i]);
            }


            //Creación de Listeners
            TextWriterTraceListener textListener = new TextWriterTraceListener(@"C\TrazaTxt.txt");
            Trace.Listeners.Add(textListener);

            XmlWriterTraceListener xmlListener = new XmlWriterTraceListener(@"C\TrazaXml.xml");
            Trace.Listeners.Add(xmlListener);

            //No funciona
            //EventLogTraceListener logListener = new EventLogTraceListener("Application");
            //Trace.Listeners.Add(EventLogListener);

            //Modificadores de seguimiento
            BooleanSwitch booleanSwitch = new BooleanSwitch("BoolenaSwitch", "Modificador booleano");
            TraceSwitch traceSwitch = new TraceSwitch("TraceSwitch", "Modificador complejo");

            //Modificador de seguimiento como condición
            Trace.WriteLineIf(booleanSwitch.Enabled, "Mensaje...");

            //Estas dos instrucciones son equivalentes
            Trace.WriteLineIf(traceSwitch.TraceInfo, "Mensaje...");
            Trace.WriteLineIf(traceSwitch.Level == TraceLevel.Info, "Mensaje...");


            //Gestión de los archivos de traza de eventos 
            //Así se verifica que no exista un evento, si no existe se crea 
            //if (!EventLog.SourceExists("Capítulo 15"))
            //{
            //    EventoLog.CreateEventSource("Capítulo 15", "Application");
            //}










            Trace.WriteLine("Fin de la aplicación");
            Trace.Flush();

            Console.ReadKey();
        }

        //Creación de contador de rendimiento 
        //Esto tambien se puede hacer directamente desde el explorador de servicios de Visual Studio 
        //public void CreateCounter()
        //{
        //    if (PerformanceCounterCategory.Exists("Capítulo 15"))
        //    {
        //        PerformanceCounterCategory.Delete("Capítulo 15")
        //    }

        //    CounterCreationData counter = new CounterCreationData("SendPerSecond", "Número de envios por segundo", PerformanceCounterType.RateOfCountsPerSecond32);

        //    CounterCreationDataCollection counters = new CounterCreationDataCollection();

        //    counters.Add(counter);

        //    PerformanceCounterCategory.Create("Capítulo 15", "Contadores de rendimiento de la aplicación Capítulo 15", PerformanceCounterCategoryType.SingleInstance, counters);
        //}
    }
}

