using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_5.Clases_Y_Miembros_Abstractos
{
    //La clase que herede de una clase abstracta debe implementar todos los miembros abstractos con la palabra reservada override
    public class ClaseHija : ClaseBase
    {
        public override bool PropiedadAbstracta { get; set; }

        public override void MetodoAbstracto()
        {
            
        }

        //También se puede crear una clase hija abstracta que derive de una clase abstracta y en este caso no es necesario implementar todos los miembros de la clase padre

        public abstract class Hija2 : ClaseBase
        {

        }
    }
}
