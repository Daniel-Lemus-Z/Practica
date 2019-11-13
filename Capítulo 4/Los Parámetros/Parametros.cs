using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Los_Parámetros
{
    public class Parametros
    {
        public static int prueba(params int [] I)
        {
            int result = 0;
            for (int i = 0; i < I.Length; i++)
            {
                result += I[i];
            }
            return result;
        }
    }
}
