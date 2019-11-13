using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Sobrecarga_De_Operadores
{
    public class SobrecargaDeOperadoresDeComparacion
    {
        public int x;
        public int y;

        public SobrecargaDeOperadoresDeComparacion()
        {

        }

        public SobrecargaDeOperadoresDeComparacion(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator == (SobrecargaDeOperadoresDeComparacion v1, SobrecargaDeOperadoresDeComparacion v2)
        {
            return (v1.x == v2.x && v1.y == v2.y);
        }

        public static bool operator != (SobrecargaDeOperadoresDeComparacion v1, SobrecargaDeOperadoresDeComparacion v2)
        {
            return !(v1.x != v2.x || v1.y != v2.y);
        }

        public static bool operator <= (SobrecargaDeOperadoresDeComparacion v1, SobrecargaDeOperadoresDeComparacion v2)
        {
            return (v1.x <= v2.x || v1.y <= v2.y);
        }

        public static bool operator >= (SobrecargaDeOperadoresDeComparacion v1, SobrecargaDeOperadoresDeComparacion v2)
        {
            return (v1.x >= v2.x || v1.y >= v2.y);
        }
    }
}
