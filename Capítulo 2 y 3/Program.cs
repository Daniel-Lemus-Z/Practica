using System;
using System.Collections;
using System.Collections.Generic;
using Capítulo_2_y_3.Clases_Estáticas;
using Capítulo_2_y_3.Constantes;
using Capítulo_2_y_3.Enumeraciones;
using Capítulo_2_y_3.Los_Alias1;
using Capítulo_2_y_3.Los_Tipos;
using alias = Capítulo_2_y_3.Los_Alias2;

namespace Capítulo_2_y_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos por valor => son datos primitivos (básicos)
            //Las estructuras y los enum también pertenecen a los tipos por valor

            int i = 1;

            bool b1 = true;
            bool b2 = b1;
            b1 = false;

            //Tipos por referencia => son los que se deben instanciar utilizando la palabra reservada "new"
            //Las clases, interfaces y delegados pertenecen a los tipos por referencia 

            TiposPorValorYReferencia C1 = new TiposPorValorYReferencia();
            C1.b = true;
            TiposPorValorYReferencia C2 = C1;
            C1.b = false;


            //Identificadores => nombres que se le asignan a las clases, miembros, variables etc

            //Palabras reservadas => son las palabras propias del lenguaje
            //La palabra "lock" es propia del sistema por lo que para usarla se  debe usar el @ para asi asignarla como identificador 
            //El carácter @ también se puede utilizar en identificadores que no entran en conflicto con las palabras reservadas

            bool @lock = true;
            bool @miIdentificador = false;


            //Reglas de puntuación

            int x = 5
                + 2;

            //El punto despues de un identificador permite acceder a los miembros de un objeto
            //miIdentificador.CompareTo
            //miIdentificador.GetType

            //Las llaves se usan para agrupar varias instrucciones dentro de un bloque de control o de un método
            //class program
            //{

            //}

            //Los parentesis se usan para declarar o llamar métodos, también se usan para agrupar las instrucciones de la misma manera que para una operación matemática 
            miIdentificador.ToString();
            //Los argumentos de un método se separan con una coma 
            //miIdentificador.Equals(parametro1, parametro2);

            //Los corchetes permiten acceder a los elementos de un array o si la clase tiene una propiedad para indexar, a los elementos de una clase
            int[] array = new int[10];
            array[0] = 1;


            //Operadores de cálculo, asignación y comparación => estos temas los domino 
            int sx = 5;
            sx += 2;       // s = 7;
            sx -= 2;       // s = 5;
            sx *= 2;       // s = 10;
            sx /= 2;       // s = 5;
            sx %= 2;       // s = 1;


            //Operadores de comparación => este tema lo domino 
            //Permite identificar si el objeto es de tipo int mostrando un true o false
            var xx = 22;
            Console.WriteLine(xx is int);
            Console.WriteLine("..................................");
            //Permite identificar si el objeto es de tipo DateTime mostrando un true o false
            DateTime x2 = new DateTime(2002, 12, 04);
            Console.WriteLine(x2 is DateTime da);
            Console.WriteLine("..................................");
            //También es posible combinar los operadores de comparación con los operadores lógicos
            //(x >= 0 || x > 10) && (x <= 1 || x < 25)


            //Declaración de variables => este tema lo domino
            //Es posible declarar e iniciar varias variables con una única instrucción, con la condición de que sean del mismo tipo
            bool bx1 = true, bx2 = false;


            //Las instrucciones condicionales (if,else, else if y switch) e instrucciones iterativas (for, while, do while y foreach) => estos temas los domino


            //Intrucciones de salto 
            //Las instrucciones de salto return y throw las domino
            for (int j = 0; j < 10; j++)
            {
                if (j == 5)
                {
                    //La palabra "break" permite salir de un bucle o instrucción sin tener que esperar a que se ejecuten tolas las instrucciones 
                    break;
                }
            }

            for (int k = 0; k < 10; k++)
            {
                if (k > 5)
                {
                    //La palabra "continue" permite parar el bucle y pasar a la siguiente instrucción
                    continue;
                }
            }

            int l = 0;
        añadir:
            l++;

            if (l < 5)
            {
                //Tranfiere la ejecución a un bloque de instrucciones 
                //En caso de ser usando dentro de un switch, lo que hace es pasar de un caso a otro
                goto añadir;
            }

            //Comentarios

            /* 
             * Comentario
             * en varias lineas
             */

            ///<sumary>
            ///Comentario para documentación
            ///</sumary>
            ///


            //Palabra reservada using => este tema lo domino
            //System.Windows.Forms.Form F = new System.Windows.Forms.Form();
            //using System.Windows.Forms;
            //Form F = new Form();


            //Alias
            //Los alias sirven por si el nombre de un tipo se define en dos espacios de nombres
            alias.Class clase2 = new alias.Class();
            Class clase = new Class();


            //Clase estática => se puede acceder a los miembros de una clase estática sin tener que instanciarla 
            ClaseEstatica.Nombre = "Pablo";
            ClaseEstatica.Apellido = "Escobar";


            //Los enteros

            //Notación decimal
            int num1 = 2;
            //Notación hexadecimal
            int num2 = 0x4B;  // 75
            //Notación binaria
            int num3 = 0b1101; //13
            //Notación equivalente
            int num4 = 100_000_000; //100000000 

            //Tipos de enteros 

            //De 0 a 255
            byte ent1 = 255;

            //De -32767 a 32767
            short ent2 = 32767;

            //De -2147483647 a 2147483647
            int ent3 = 2147483647;

            //De -9223372036854775807 a  9223372036854775807
            long ent4 = 9223372036854775807;

            //De -128 a 127
            sbyte ent5 = 127;

            //De 0 a 65535
            ushort ent6 = 65535;

            //De 0 a 4294967295
            uint ent7 = 4294967295;

            //De 0 a 18446744073709551615
            ulong ent8 = 18446744073709551615;


            //Los decimales 
            float dec1 = 1.123f;      // 7 cifras significativas
            double dec2 = 2.12;      // 15 cifras significativas
            decimal dec3 = 3.234m;  // 28 cifras significativas

            //Los booleanos => este tema lo domino
            byte bxd = 1;
            bool hb = bxd < 2;

            //Las cadenas de caracteres => este tema lo domino

            //Carácter unicode => formato hexadecimal 
            char c2 = '\u0061';  // a

            string xa = "Mi cadena";
            string xb = "Mi-Cadena";

            //Métodos para manipular cadenas 
            var xxa = String.Format("Ejemplo {0} {1} {2}", 1, 2, 3); // Ejemplo 1 2 3
            var xxb = xa.Replace("cadena", "ejemplo"); // Mi ejemplo
            var xxc = xb.Split('-'); // Explicación
            var xxd = xa.Substring(2); // cadena
            var xxe = xa.ToCharArray(); // devuelve un array de tipo char a partir de la cadena
            var xxf = xa.ToLower(); // convierte todos los caracteres en minúsculas
            var xxg = xa.ToUpper(); // convierte todos los caracteres en mayúsculas
            var xxh = xa.Trim(); // elimina los espacios al inicio y final de la cadena


            //Los tipos nulos
            string s = null;
            //Esta operación no esta permitida => int t = null;
            //Para asignarle a un tipo por valor un null se debe hacer con la siguiente sintaxis
            int? t = null;

            //Estas dos operaciones son equivalentes 
            if (t != null)
            { }
            if (t.HasValue)
            { }

            //La conversión de un tipo clásico hacia un tipo null es implícita
            //La conversión de un tipo que admite valores nulos en un tipo que admite valores clásicos es explícita
            int u = (int)t;

            //Conversión implícita
            int num5 = 1;
            long num6 = num5;

            //Conversión explícita
            short num7 = 300;
            byte num8 = (byte)num7;

            //Constante
            //Según el nivel de acceso, una constante se puede usar fuera de su clase llamandola como un miembro estático
            int v = Constante.DiasDeLaSemana;
            int w = Constante.MesesDelAño;

            //Enumeraciones
            //Las enumeraciones necesitan conversiones explícitas para ser asignadas a los tipos básicos
            int z = (int)Enumeración.Lunes;

            //Los operadores lógicos como  & y | permiten realizar operaciones de asignación
            Enumeración FinDeSemana = Enumeración.Sábado | Enumeración.Domingo;
            Enumeración Asignacion = Enumeración.Lunes & Enumeración.Martes;

            //Array
            //Arreglo de cadenas
            string[] Array = new string[5];
            Array[0] = "Juan";
            Array[1] = "Pedro";
            Array[2] = "Daniel";
            Array[3] = "Camilo";
            Array[4] = "David";

            //Areglo de números
            int[] ArrayNúmeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Arreglos multidimensionales => regulares
            int[,] Arrayx = new int[2, 2];
            int[,,] Arrayy = new int[5, 3, 2];

            //Arreglos de arreglos => escalares
            //int[][] Arrays = new int[2][];
            //Array[0] = new int[] { 2, 5 };
            //Array[1] = new int[] { 2, 5, 12, 21 };

                
            //Collections
            //ArrayList
            ArrayList animalesDomesticos = new ArrayList();
            animalesDomesticos.Add("Perro");
            animalesDomesticos.Add("Gato");
            animalesDomesticos.Add("Pajaro");


            ArrayList miColeccion = new ArrayList();
            miColeccion.Add(new object());
            miColeccion.Insert(0, "ABCD");

            //Debido a que mi coleccion es de tipo object, puedo añadir varios tipos de objeto diferentes, por lo que para su recuperación se debe convertir explícitamente
            string sp = (string)miColeccion[0];

            //El búcle foreach permite reccorrer todos los miembros 
            foreach (object o in miColeccion)
            {
                
            }

            //Con este búcle se comprueba el tipo del objeto
            foreach (object o in miColeccion)
            {
                if (o.GetType() == typeof(string))
                {

                }
            }
 
            //List
            List<string> Meses = new List<string>();
            Meses.Add("Enero");
            Meses.Add("Marzo");
            Meses.Add("Mayo");

            //Diccionario 
            Dictionary<int, string> personas = new Dictionary<int, string>
            {
                { 1, "Pedro" },
                { 2, "Juan" }
            };




        }
    }
}
