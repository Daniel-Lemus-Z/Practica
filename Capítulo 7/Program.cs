using Capítulo_7.Eventos;
using Capítulo_7.Expresiones_Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_7
{
    public class Program
    {
        //Son objetos especiales que tienen referencia a un método

        //Un delegado es un tipo que encapsula de forma segura un método, es una especie de puente entre la llamada a un método
        //y el método deseado

        //Los delegados se dividen en tipos e instancias 
        //Los delegados solo contienen la declaración del método

        //Los tipos de delegados son sealed (no se pueden derivar) y no se pueden derivar clases personalizadas de Delegate

        public delegate int Calculo(int i, int j);

        public delegate void Mostrar(int i);

        //Un delegado puede contener parámetros de tipo genérico, en este caso, el tipo de indicara durante su instanciación 
        public delegate T Calculo<T>(T i, T j);


        delegate void Delegado1();
        delegate void Delegado2();

        //Delegado1 D1 = MiMetodo;
        //Delegado2 D2 = D1;  => esto no esta permitido

        //Es posible asignar un delegado apartir de otro que tiene la misma declaración, pero con la notación completa
        //Delegado2 D2 = new Delegado2(D1);

        public delegate string Concatenar1(string s1, string s2);

        public delegate object Concatenar2(string s1, string s2);


        static void Main(string[] args)
        {
            ClaseConEventos1 e = new ClaseConEventos1();
            //Se crea el evento y asigna el metodo estatico al evento, 

            //El operador += indica que se esta suscribiendo al evento
            //El operador -= indica que se esta desuscribiendo al evento

            e.evento += OnEvento;
            //hace lo mismo que la primera pero con el EventHandler, ambas funcionan igual
            e.evento += new ClaseConEventos1.EventHandler(OnEvento);

            e.OnEvento("HolaMundo");


            //----------------------------------------------------------------------------------------------------------
            ClaseConEventos2 obj1 = new ClaseConEventos2();
            string result = obj1.WelcomeUser("Daniel");
            Console.WriteLine(result);







            //Lambdas
            Lambdas l = new Lambdas();
            l.Multiplicacion();
            l.ValorAbs();


            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            //Las expresiones lambda también se pueden convertir en los tipos de árbol de expresión
            System.Linq.Expressions.Expression<Func<int, int>> f = x => x * x;



            //Captura de variables
            int cv1 = CapturaDeVariables.Test1(2);
            Console.WriteLine(cv1);

            int cv2 = CapturaDeVariables.Test2(2);
            Console.WriteLine(cv2);

            CapturaDeVariables.Test3();



            Func<string>[] F = new Func<string>[3];
            for (int i = 0; i < 3; i++)
            {
                F[i] = () => i.ToString();
            }

            string s = string.Empty;
            foreach (Func<string> p in F)
            {
                Console.WriteLine(s += p());
            }


            for (int i = 0; i < 3; i++)
            {
                int j = i;
                F[i] = () => j.ToString();
                Console.WriteLine(j);
            }



            Console.ReadLine();








        }

        //Los eventos proporcionan un medio apropiado para que los objetos puedan señalizar cambios de estado 
        //que pueden resultar útiles para los clientes de ese objeto

        public static void OnEvento(String s)
        {
            Console.WriteLine(s);
        }

    }
}
