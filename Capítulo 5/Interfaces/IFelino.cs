using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_5.Interfaces
{
    //Las interfaces pueden heredar de otras interfaces 
    public interface IFelino : IAnimal
    {
        //Los miembros de una interfaz no llevan modificadores de acceso ni las palabras reservadas static o virtual, estas implementaciones se hacen en las clases que deriven de esta
        string Aceleracion { get; set; }

        string Correr(int velocidad);
    }
}
