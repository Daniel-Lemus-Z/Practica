using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_5.Clases_Y_Metodos_Cerrados
{
    //La palabra reservada sealed en una declaración permite prohibir que se herede de la clase que la tenga 
    //Sus miembros no pueden ser virtuales ni tener el modificador de acceso protected 
    public sealed class ClaseBase
    {
        public bool PropiedadBase { get; set; }

        public void MetodoBase()
        {

        }
    }
}
