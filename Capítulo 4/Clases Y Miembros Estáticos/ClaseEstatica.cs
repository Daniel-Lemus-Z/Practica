using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Clases_Y_Miembros_Estáticos
{
    public static class ClaseEstatica
    {
        //La palabra reservada static nos permite compartir los miembros entres varias intancias y crear clases que no necesiten ser instaciadas 
        //Los miembros que se marcan con la palabra reservada static solo existen una vez 

        public static string  NombreCamiseta;
        public static int Dorsal;

        public static void Prueba()
        {

        }
    }
}
