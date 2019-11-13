using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_5.Constructores_Derivados
{
    public class ClaseBase
    {
        public virtual int PropiedadBase { get; set; }

        public ClaseBase()
        {
            this.PropiedadBase = 10;
        }

        public ClaseBase(int i)
        {
            this.PropiedadBase = i;
        }


    }
}
