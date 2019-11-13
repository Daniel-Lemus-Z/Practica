using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Los_Parámetros
{
    public class ParametrosOpcionales
    {
        public static int PruebaPO(int num1, int num2, int num3 = 0)
        {
            int resultado = num1 + num2 + num3;
            return resultado;
        }
    }
}
