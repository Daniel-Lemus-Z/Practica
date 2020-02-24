using Capítulo_7.Delegados.Delegados_Genéricos;
using Capítulo_7.Eventos_RAYADO;
using Capítulo_7.Expresiones_Lambda_RAYADO;
using Capítulo_7.Expresiones_Lambda.CapturaDeVariables;
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
            Lambdas lb = new Lambdas();
            lb.Multiplicacion2();
            
            
            TestEventos tE = new TestEventos();
            tE.TestEvento();


            // Delegados genéricos
            Clase1DG dg = new Clase1DG(5, 2);
         

            ClaseConEventos1 e = new ClaseConEventos1("a");
            //Se crea el evento y asigna el metodo estatico al evento, 

            //El operador += indica que se esta suscribiendo al evento
            //El operador -= indica que se esta desuscribiendo al evento


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

            CapturaDeVariables.Test4();
                                   


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
