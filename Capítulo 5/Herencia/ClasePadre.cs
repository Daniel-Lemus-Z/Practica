using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Capítulo_5.Herencia
{
    //Esta clase hereda de Object implícitamente
    public class ClasePadre
    {

        public ClasePadre()
        {
       
        }

        public void xx()
        {
            // Me = this
            // base = MyBase
            // ---- = MyClass

            Debug.WriteLine(this.PropiedadBase);        
        }



        //La palabra reservada virtual me permite sobrecargar las propiedades o métodos que la contengan en las clases hijas
        //Cabe aclarar que estos métodos o propiedades deben llevar la palabra override cuando sean sobrecargados
        public virtual string PropiedadBase { 
            get {
                return "hola mano!";
            } 
        }

        public virtual void MetodoBase()
        {

        }

        public virtual void MetodoBaseOculto()
        {

        }


    }
}
