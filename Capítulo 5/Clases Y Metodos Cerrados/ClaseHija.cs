using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_5.Clases_Y_Metodos_Cerrados
{
    public class ClaseHija : ClaseBase2
    {
        public sealed override void MetodoBase()
        {
            
        }


    }


    public class ClaseHija2 : ClaseHija
    {
        //Esto no esta permitido debido a que la clase "ClaseHija" declaro el método base con sealed por lo que detuvo la herencia 
        //public override void MetodoBase()
        //{

        //}

        //Siempre es posible realizar una sobrecargar con la palabra reservada new
        public new void MetodoBase()
        {

        }
    }
}
