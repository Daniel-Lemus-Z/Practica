using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Capítulo_26
{
    public delegate void CustomCallback(string returnValue);

    public class ThreadExamples
    {

        public static void CreateThread()
        {
            //Creación de un Thread
            Console.WriteLine("Inicio del thread principal");
            //En el constructor debe ir como argumento la declaración del método que se ejecutará 
            ThreadStart newThread = new ThreadStart(OtherThread);
            //El delegado se pasa como argumento del constructor
            Thread thread = new Thread(newThread);
            thread.Start();
            Console.WriteLine("Thread principal terminado");
        }
        
        public static void CancelThread()
        {
            //Supende el Thread durante un lapso de tiempo
            Thread.Sleep(2000);

            //La anulación de un thread se realiza llamando al método Abort de la clase Thread
            Thread thread2 = new Thread(new ThreadStart(OtherThread));
            thread2.Start();
            Console.WriteLine("Anulación del thread desde OtherThread ");
            thread2.Abort();

            thread2 = new Thread(new ThreadStart(AbortThread));
            thread2.Start();
        }

        public static void ExchangeDataType1()
        {
            //La primera consiste en utilizar un delegado del tipo ParameterizedThreadStart durante la instanciación del nuevo thread

            //Esta manera es fácil de implementar, pero tiene un inconveniente. El tipo del argumento no se garantiza, pues el
            //método Start acepta cualquier tipo de objeto

            Thread thread3 = new Thread(new ParameterizedThreadStart(ParameterizedThread));
            thread3.Start(10);
        }

        public static void ExchangeDataType2()
        {
            //La segunda manera de pasar los datos a un thread consiste en encapsular el método del thread y los datos en una clase

            //De esta manera, el nuevo thread tiene acceso a los datos asignados por otro thread

            CustomThread cThread = new CustomThread()
            {
                intValue = 10,
                stringValue = "Mi valor"
            };

            Thread thread = new Thread(
                           new ThreadStart(cThread.ThreadMethod));
            thread.Start();
        }

        public static void ExchangeDataType3()
        {
            //De la misma manera que resulta interesante poder pasar valores a un thread, lo es poder recuperar los datos de
            //retorno de ejecución de un thread. La técnica consiste en recuperar la encapsulación del método del thread en una
            //clase a la que se añade un delegado personalizado

            CustomThread2 cThread = new CustomThread2()
            {
                intValue = 10,
                stringValue = "Mi valor",
                Callback = new CustomCallback(DisplayCallback)
            };

            Thread thread = new Thread(
                           new ThreadStart(cThread.ThreadMethod));
            thread.Start();
        }

        public static void BlockThread()
        {
            //Un thread se puede bloquear para que pueda terminar sin que una nueva instancia del método se ejecute

            CustomThread3 cThread = new CustomThread3();
            Thread thread1 = new Thread(
                               new ThreadStart(cThread.LockedThread));
            thread1.Start();
            Thread thread2 = new Thread(
                               new ThreadStart(cThread.LockedThread));
            thread2.Start();
        }

        public static void PriorityThread()
        {
            //La propiedad Priority de la clase Thread
            //permite modificar esta prioridad relativa, con uno de los valores de la enumeración ThreadPriority: Highest,
            //AboveNormal, Normal, BelowNormal y Lowest

            Console.WriteLine("Inicio de threads sin prioridad");
            Thread thread1 = new Thread(new ThreadStart(Counter1));
            Thread thread2 = new Thread(new ThreadStart(Counter2));
            thread1.Start();
            thread2.Start();
            Console.ReadLine();
            Console.WriteLine("Inicio de threads con prioridad");
            thread1 = new Thread(new ThreadStart(Counter1));
            thread2 = new Thread(new ThreadStart(Counter2));
            thread1.Priority = ThreadPriority.Lowest;
            thread2.Priority = ThreadPriority.Highest;
            thread1.Start();
            thread2.Start();
        }























        public static void OtherThread()
        {
            Console.WriteLine("Inicio del thread secundario");

            Console.WriteLine("Thread secundario terminado");
        }

        public static void AbortThread()
        {
            Console.WriteLine("Anulación del thread desde Thread.CurrentThread.Abort");

            Thread.CurrentThread.Abort();
        }

        public static void ParameterizedThread(object o)
        {
            Console.WriteLine("Valor pasado al thread: {0}", o);
        }

        public class CustomThread
        {
            public int intValue { get; set; }
            public string stringValue { get; set; }
            public void ThreadMethod()
            {
                Console.WriteLine("Valores pasados al thread:");
                Console.WriteLine("intValue = {0}", intValue);
                Console.WriteLine("stringValue = {0}", stringValue);
            }
        }

        public static void DisplayCallback(string s)
        {
            Console.WriteLine("Valor devuelto: {0}", s);
        }

        public class CustomThread2
        {
            public int intValue { get; set; }
            public string stringValue { get; set; }
            public CustomCallback Callback { get; set; }
           
            public void ThreadMethod()
            {
                if (Callback != null)
                    Callback(string.Format("{0}: {1}",
                                           stringValue,
                                           intValue));
            }
        }

        public class CustomThread3
        {
            public void LockedThread()
            {
                //La palabra reservada lock delimita la sección de código que se debe bloquear
                lock (this)
                {
                    Console.WriteLine("El thread está bloqueado");
                    Thread.Sleep(2000);
                    Console.WriteLine("El thread está desbloqueado");
                }
            }
        }

        public static void Counter1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0} ", i);
            }  
        }

        public static void Counter2()
        {
            for (int i = 11; i <= 20; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
