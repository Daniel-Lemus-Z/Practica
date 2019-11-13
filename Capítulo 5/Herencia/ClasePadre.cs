using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_5.Herencia
{
    //Esta clase hereda de Object implícitamente
    public class ClasePadre
    {
        //La palabra reservada virtual me permite sobrecargar las propiedades o métodos que la contengan en las clases hijas
        //Cabe aclarar que estos métodos o propiedades deben llevar la palabra override cuando sean sobrecargados
        public virtual bool PropiedadBase { get; set; }

        public virtual void MetodoBase()
        {

        }

        public virtual void MetodoBaseOculto()
        {

        }


    }
}
