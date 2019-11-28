using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_6.Interfaces_Genéricas.Herencia_De_Interfaces_Genéricas_Variantes
{
    interface IHija2<out T> : IPadre<T>
    {
    }
}
