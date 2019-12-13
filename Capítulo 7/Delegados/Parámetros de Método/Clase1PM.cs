using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Capítulo_7.Program;

namespace Capítulo_7.Delegados.Parámetros_de_Método
{
    public class Clase1PM
    {
        //Los delegados se puede utilizar como parámetros de un método

        public void Adicion(int i, int j, Mostrar CB)
        {
            CB(i + j);
        }

        public void Muestra(int i)
        {
            Console.WriteLine(i);
        }

        public Clase1PM(int i, int j)
        {
            Mostrar A = new Mostrar(Muestra);
            Adicion(i, j, A);
        }

    }
}
