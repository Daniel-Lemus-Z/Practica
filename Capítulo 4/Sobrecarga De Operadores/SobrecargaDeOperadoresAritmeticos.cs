using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Sobrecarga_De_Operadores
{
    public class SobrecargaDeOperadoresAritmeticos
    {
        public int x;
        public int y;

        public SobrecargaDeOperadoresAritmeticos()
        {

        }

        public SobrecargaDeOperadoresAritmeticos(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "Resultado #1: " + x + "\nResultado #2: " + y;
        }

        public static SobrecargaDeOperadoresAritmeticos operator + (SobrecargaDeOperadoresAritmeticos v1, SobrecargaDeOperadoresAritmeticos v2)
        {
            return new SobrecargaDeOperadoresAritmeticos()
            {
                x = v1.x + v2.x,
                y = v1.y + v2.y
            };
        }

        public  static SobrecargaDeOperadoresAritmeticos operator - (SobrecargaDeOperadoresAritmeticos v1, SobrecargaDeOperadoresAritmeticos v2)
        {
            return new SobrecargaDeOperadoresAritmeticos()
            {
                x = v1.x - v2.x,
                y = v1.y - v2.y
            };
        }

        public static SobrecargaDeOperadoresAritmeticos operator * (SobrecargaDeOperadoresAritmeticos v1, SobrecargaDeOperadoresAritmeticos v2)
        {
            return new SobrecargaDeOperadoresAritmeticos()
            {
                x = v1.x * v2.x,
                y = v1.y * v2.y
            };
        }

        public static SobrecargaDeOperadoresAritmeticos operator / (SobrecargaDeOperadoresAritmeticos v1, SobrecargaDeOperadoresAritmeticos v2)
        {
            return new SobrecargaDeOperadoresAritmeticos()
            {
                x = v1.x / v2.x,
                y = v1.y / v2.y
            };
        }

        public static SobrecargaDeOperadoresAritmeticos operator % (SobrecargaDeOperadoresAritmeticos v1, SobrecargaDeOperadoresAritmeticos v2)
        {   
            return new SobrecargaDeOperadoresAritmeticos()
            {
                x = v1.x % v2.x,
                y = v1.y % v2.y
            };
        }
    }
}
