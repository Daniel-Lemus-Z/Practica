using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Constructores_Y_Destructores
{
    public class ClaseConDestructor
    {

        public string Nombre;


        //Destructor
        //Los destructores son métodos que se ejecutan automáticamente 
        //Los destructores me sirven para el proceso de recuperación de memoria para un objeto que no se referencie más

        //Declaración de un destructor
        ~ClaseConDestructor()
        {
            Console.WriteLine("Instancia destruida");
        }

        //Declaración de un destructor en forma de expresión
        //~ClaseConDestructor() => Nombre = null;
    }
}
