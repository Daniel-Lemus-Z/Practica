using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_5.Herencia
{
    //Esta clase hereda de Objet implícitamente
    public class ClaseHija : ClasePadre
    {
        public override void MetodoBase()
        {
            //la palabra reservada base me permite llamar cualquier miembro de la clase base en la clase hija
            base.MetodoBase();
            var b = this.PropiedadBase;
            var b2 = base.PropiedadBase;
        }

        public override string PropiedadBase
        {
            get
            {
                return "hola mano! XXX MANOO";
            }
        }

        //Aquí el método hijo esta ocultando el método base, ya no lleva la palabra reservada override o virtual
        //Esto nos lanzara una excepcion
        public void MetodoBaseOculto()
        {

        }

        //Para arreglar esto hay que agregar la palabra reservada new
        //public new void MetodoBaseOculto()
        //{

        //}
    }   
}
