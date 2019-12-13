using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Capítulo_7.Program;

namespace Capítulo_7.Delegados.Delegados_Genéricos
{
    public class Clase1DG
    {
        public Clase1DG(int i, int j)
        {
            Calculo<int> C = new Calculo<int>(Adicion);
            int resultado = C.Invoke(i, j);
        }

        public int Adicion (int i, int j)
        {
            return i + j;
        }
    }
}
