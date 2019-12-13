using Capítulo_4.Clases_Y_Miembros_Estáticos;
using Capítulo_4.Constructores_Y_Destructores;
using Capítulo_4.Estructuras;
using Capítulo_4.Indexadores;
using Capítulo_4.Los_Parámetros;
using Capítulo_4.Métodos;
using Capítulo_4.Sobrecarga_De_Operadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Estructuras
            //Las estructuras contienen un constructor vacio implícitamente y este no se puede sobrecargar
            Estructura estructuraEjemplo = new Estructura();

            //Métodos => este tema lo domino

            //Sobrecarga de métodos
            SobrecargaDeMetodos SDM = new SobrecargaDeMetodos();
            Console.WriteLine("Método #1: " + SDM.Suma(12, 12));
            Console.WriteLine("..................................");
            Console.WriteLine("Método #2: " + SDM.Suma(12, 12, 12));
            Console.WriteLine("..................................");
            Console.WriteLine("Método #3: " + SDM.Suma("Hola","Mundo"));
            Console.WriteLine("..................................");


            //Paso por valor
            //En el paso por valor se crea una copia del valor que se esta pasando, por lo que no se modificara nunca el original 
            int numero = 35;
            Console.WriteLine("Número : " + numero);
            PasoPorValor.PruebaPV(numero);
            Console.WriteLine("..................................");

            //Paso por referencia con ref
            //En el paso por referencia con ref no se crea una copia del valor que se esta pasando, se pasa el variable original 
            int numero2 = 50;
            PasoPorReferenciaConRef.PruebaPRRef(ref numero2);
            Console.WriteLine("Número despues : " + numero2);
            Console.WriteLine("..................................");

            //Paso por referencia con out
            //La palabra out es semejante a ref, permite pasar una variable por referencia que no se debe asignar antes de enviarla por el método, pero se debe asignar antes de que salga de esté
            PasoPorReferenciaConOut.PruebaPROut(out int numero1);
            Console.WriteLine("..................................");
            PasoPorReferenciaConOut.prueba(out string S1, out string S2);
            Console.WriteLine("..................................");

            //Palabra reservada params
            Parametros.prueba(1);
            Parametros.prueba(1, 2);
            Parametros.prueba();
            Parametros.prueba(new int[] { 1, 2, 4, 8, 16 });
            Parametros.prueba(new int[] {  });

            //Parámetros opcionales
            //Un parámetro es opcional cuando en la declaración del método se le asigna un valor a uno de ellos, esto quiere indicar que al usar el método se puede mandar el parámetro o no y no afecta
            //el resultado
            //Los parámetros obligatorios deben estar antes que los opcionales
            //Estos parámetros no se pueden marcar con las palabras reservadas out o ref
            Console.WriteLine("Parámetros opcionales : "  + ParametrosOpcionales.PruebaPO(20, 45));
            Console.WriteLine("Parámetros opcionales : " + ParametrosOpcionales.PruebaPO(20, 45, 5));
            Console.WriteLine("..................................");

            //Parámetros nombrados
            //Se utilizan mayormente en los métodos que contienen parámetros opcionales, aquí lo que se hace es asignarle directamente el valor que queremos que tenga un parámetro en concreto de un método
            ParametrosNombrados.PruebaPN(num1: 2, 2, 3, num4:3);
            ParametrosNombrados.PruebaPN2(b1: true, false);

            //NameOf
            //Sirve para que al momento de que nosotros estemos utilizando el nombre de una variable no la tengamos que "quemar" en el sistema si no que la obtenemos con el nameof
            //esto nos ayuda para que al momento de que cambiemos el nombre de esa variable y refactorizemos el programa siga funcionando correctamente, ya que si tenemos el nombre quemado existe la 
            //posibiidad de que se nos olvide cambiar este y el codigo falle
            string nombre = "Juan";
            Console.WriteLine(nameof(nombre));
            Console.WriteLine(nameof(Parametros));
            Console.WriteLine(nameof(Parametros.Equals));
            Console.WriteLine("..................................");

            //Tuplas
            //Me permiten devolver varios valores en una sola llamada
            //var nombres = Tuplas.SeparaNombre("Pablo-Escobar");
            //Console.WriteLine("Tupla: " + nombres.nom1);
            //Console.WriteLine("Tupla: " + nombres.nom2);
            Console.WriteLine("..................................");

            //Constructores
            //Inicialice la clase con un constructor vacio 
            ClaseConConstructores constructorVacio = new ClaseConConstructores();
            //Inicialice la clase con un constructor con parámetros
            ClaseConConstructores constructorConParametros = new ClaseConConstructores("Daniel", "Lemus");

            //Clase Estática
            ClaseEstatica.NombreCamiseta = "Lemus";
            ClaseEstatica.Dorsal = 5;
            ClaseEstatica.Prueba();

            //Indexadores
            //Nos proporcionan una forma intuitiva de acceder a los miembros de un objeto que encapsula un array o una colección
            //Los indexadores utilizan los corchetes [ ] para acceder a los elementos

            string s = "Hola";
            char c = s[2];
            Console.WriteLine(c);
            Console.WriteLine("..................................");

            ClaseConIndexadores p = new ClaseConIndexadores();
            string s1 = p[0];
            Console.WriteLine(s1);
            Console.WriteLine("..................................");

            //Sobrecarga de operadores aritmeticos
            SobrecargaDeOperadoresAritmeticos V1 = new SobrecargaDeOperadoresAritmeticos(20, 30);
            SobrecargaDeOperadoresAritmeticos V2 = new SobrecargaDeOperadoresAritmeticos(40, 60);
            SobrecargaDeOperadoresAritmeticos ResultadoS = V1 + V2;
            
            Console.WriteLine("Suma: " + "\n" + ResultadoS);
            Console.WriteLine("..................................");

            SobrecargaDeOperadoresAritmeticos ResultadoR = V1 - V2;
            Console.WriteLine("Resta: " + "\n" + ResultadoR);
            Console.WriteLine("..................................");

            SobrecargaDeOperadoresAritmeticos ResultadoM = V1 * V2;
            Console.WriteLine("Multiplicacion: " + "\n" + ResultadoM);
            Console.WriteLine("..................................");

            SobrecargaDeOperadoresAritmeticos ResultadoD= V1 / V2;
            Console.WriteLine("Division: " + "\n" + ResultadoD);
            Console.WriteLine("..................................");

            SobrecargaDeOperadoresAritmeticos ResultadoMod = V1 % V2;
            Console.WriteLine("Modulo: " + "\n" + ResultadoMod);
            Console.WriteLine("..................................");

            //Sobrecarga de operadores de comparación
            SobrecargaDeOperadoresDeComparacion V3 = new SobrecargaDeOperadoresDeComparacion(25, 35);
            SobrecargaDeOperadoresDeComparacion V4 = new SobrecargaDeOperadoresDeComparacion(50, 70);
            
            bool Resultado1 = V3 != V4;
            Console.WriteLine("Operador de comparacion != :" + Resultado1);
            Console.WriteLine("..................................");

            bool Resultado2 = V3 == V4;
            Console.WriteLine("Operador de comparacion == :" + Resultado2);
            Console.WriteLine("..................................");

            bool Resultado3 = V3 <= V4;
            Console.WriteLine("Operador de comparacion <= :" + Resultado3);
            Console.WriteLine("..................................");
            
            bool Resultado4 = V3 >= V4;
            Console.WriteLine("Operador de comparacion >= :" + Resultado4);
            Console.WriteLine("..................................");
            Console.ReadKey();



            ClaseConDestructor x = new ClaseConDestructor();

            x = null;



        }
    }
}
