using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Capítulo_7.Program;

namespace Capítulo_7.Delegados
{

    public class Clase1
    {
        public Clase1(int i,int j)
        {
            Calculo C = new Calculo(Adicion);
            int result = C.Invoke(i, j);

            //Notación abreviada de instancia un delegado
            //Calculo C = Adicion;

            //Notación abreviada para la invocación de un delegado
            //int result = C(i, j);
        }

        //Para crear una instancia de delegado, es suficiente con asignar un método cuya declaración sea igual a la del delegado 
        public int Adicion (int i, int j)
        {
            return i + j;
        }
    }
}
