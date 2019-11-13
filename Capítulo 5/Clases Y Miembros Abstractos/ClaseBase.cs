using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_5.Clases_Y_Miembros_Abstractos
{   //Las clases abstractas no se pueden instanciar y sus métodos no tienen declaración 
    //por lo que las clases abstractas deben ser heredadas y las clases que hereden de esta deben implementar sus funcionalidades
    
    //Las clases abstractas se crean con el objetivo de definir la forma de las clases hijas sin tener que definir el fondo
    public abstract class ClaseBase
    {
        //Las clases abstractas pueden contener miembros no abstractos que implementen su propia lógica y se pueden marcar como virtuales para así poder sobreescribirlos en las clases que hereden
        public virtual bool PropiedadBase { get; set; }

        public abstract bool PropiedadAbstracta { get; set; }

        public virtual void MetodoBase()
        {

        }

        public abstract void MetodoAbstracto();


    }
}
