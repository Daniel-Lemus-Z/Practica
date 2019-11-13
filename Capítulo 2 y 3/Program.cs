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


            //Reglas de puntuación => este tema lo domino 

            //Operadores de cálculo, asignación y comparación => estos temas los domino 
            

            //Operadores de comparación
            //Permite identificar si el objeto es de tipo int mostrando un true o false
            var x = 22;
            Console.WriteLine(x is int);
            Console.WriteLine("..................................");
            //Permite identificar si el objeto es de tipo DateTime mostrando un true o false
            DateTime x2 = new DateTime(2002, 12, 04);
            Console.WriteLine(x2 is DateTime da);
            Console.WriteLine("..................................");


            //Declaración de variables => este tema lo domino

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


            //Alias
            alias.Class2 clase2 = new alias.Class2();
            Class clase = new Class();


            //Clase estática => se puede acceder a los miembros de una clase estática sin tener que instanciarla 
            ClaseEstatica.Nombre = "Pablo";
            ClaseEstatica.Apellido = "Escobar";

            //Los enteros
            //Notación decimal
            int num1 = 2;
            //Notación hexadecimal
            int num2 = 0x4B;
            //Notación binaria
            int num3 = 0b1101;
            //Notación equivalente
            int num4 = 100_000_000;

            //Los decimales => este tema lo domino
            //Los booleanos => este tema lo domino
            //Las cadenas de caracteres => este tema lo domino

            //Carácter unicode
            char c2 = '\u0061';

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
            int[] ArrayNúmeros = new int[]
            {
            1,2,3,4,5,6,7,8,9,10
            };

            //Collections
            //ArrayList
            ArrayList animalesDomesticos = new ArrayList();
            animalesDomesticos.Add("Perro");
            animalesDomesticos.Add("Gato");
            animalesDomesticos.Add("Pajaro");

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
