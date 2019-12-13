using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Capítulo_7.Program;

namespace Capítulo_7.Delegados.Métodos_de_destino_múltiples
{
    //Si un delegado tiene un tipo de retorno diferente de void, el objeto que lo invoque recibirá el
    //valor de retorno del  último método invocado por el delegado. 
    //Se llama a los métodos anteriores, pero su valor de retorno se pierde. 

    public class MetodosMultiples
    {
        public MetodosMultiples(int i, int j)
        {
            Calculo C = new Calculo(Adicion);
            int result = C.Invoke(i, j);

            //Un delegado puede hacer referencia a uno o varios métodos
            //Los operadores += y -= permiten añadir o eliminar referencias de método de un delegado
            C += Adicion;   //Equivalente a C = C + Adicion
            C -= Adicion;   //Equivalente a C = C - Adicion

            //Un delegado se puede inicializar con null 
            Calculo B = null;
            B += Adicion;  //Equivalente a B = Adicion 
            
            //La eliminación de una referencia de método con el operador -= sobre un delegado, es equivalente a asignar el valor null al delegado
            Calculo A = new Calculo(Adicion);
            A -= Adicion;  //Equivalente a A = null

        }

        
        public int Adicion(int i, int j)
        {
            return i + j;
        }
    }
}
