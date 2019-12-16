using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_5.Constructores_Derivados
{
    public class ClaseBase : Object
    {
        public virtual int PropiedadBase { get; set; }

        public ClaseBase()
        {

        }

        ////public ClaseBase()
        ////{
        ////    this.PropiedadBase = 10;
        ////}

        public ClaseBase(int i) : base()
        {
            this.PropiedadBase = i;
        }
        
        public ClaseBase(int i, int j) : base()
        {
            this.PropiedadBase = i;
        }


    }
}
