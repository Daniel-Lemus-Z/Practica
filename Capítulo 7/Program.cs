﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_7
{
    public class Program
    {
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
            
        }
    }
}
