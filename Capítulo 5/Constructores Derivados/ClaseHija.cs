using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_5.Constructores_Derivados
{
    public class ClaseHija : ClaseBase
    {
        public ClaseHija()
        {
            this.PropiedadBase = 5;
        }

        //public ClaseHija() : base(5)
        //{

        //}

        public ClaseHija(int i) : base(i)
        {

        }

    }
}
