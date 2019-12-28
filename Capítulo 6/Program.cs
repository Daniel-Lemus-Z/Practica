using Capítulo_6.Interfaces_Genéricas.Covarianza_Y_Contravarianza;
using Capítulo_6.Tipos_Genéricos;
using System;
using System.Collections.Generic;
using Capítulo_2_y_3.Constantes;

namespace Capítulo_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos Genéricos

            //ClaseGenerica<int> cg1 = new ClaseGenerica<int>();
            //ClaseGenerica<Object> cg2 = new ClaseGenerica<object>();
            ClaseGenerica<Clase2> cg3 = new ClaseGenerica<Clase2>();

            ClaseGenerica2<int, string> cg4 = new ClaseGenerica2<int, string>();


           
            //Covarianza en interfaces genéricas
            //Una interfaz covariante permite devolver tipos más variados que lo que se hayan especificado 

            //El método Write acepta una coleccion de tipo Clase1, la covarianza permite llamar al método con una coleccion de tipo Clase2 debido a que esta es hija de Clase1
            IEnumerable<Clase2> Elementos2 = new List<Clase2>();
            Program2.Write(Elementos2);

            //Contravarianza en interfaces genéricas
            //Capacidad de una interfaz de aceptar argumentos genéricos menos variados que los especificos

            //La clase CompararX se usa para hacer comparaciones entre objetos de tipo ClaseX1, debido a que esta implementa una interfaz contravariante permite realizar conversiones
            //implícitas hacia un tipo más variado
            IEqualityComparer<ClaseX1> clasex1 = new CompararX();
            IEqualityComparer<ClaseX2> clasex2 = clasex1;


        }
    }
}
