using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_6.Interfaces_Genéricas.Herencia_De_Interfaces_Genéricas_Variantes
{
    interface IPadre<out T>
    {

    }

    //Esto no esta permitido debido a que el padre es covariante y la hija es contravariante, tampoco se puede hacer a la inversa
    //interface IHija<in T> : IPadre<T>
    //{

    //}
}
