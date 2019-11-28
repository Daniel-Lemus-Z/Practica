using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_6.Interfaces_Genéricas.Covarianza_Y_Contravarianza
{
    public class CompararX : IEqualityComparer<ClaseX1>
    {
        public int GetHashCode(ClaseX1 clasex1)
        {
            return clasex1.GetHashCode();
        }

        public bool Equals(ClaseX1 x, ClaseX1 y)
        {
            return x == y;
        }
    }
}
