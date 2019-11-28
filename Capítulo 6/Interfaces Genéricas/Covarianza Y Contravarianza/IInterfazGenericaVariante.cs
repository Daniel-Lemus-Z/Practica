using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_6.Interfaces_Genéricas.Covarianza_Y_Contravarianza
{

    //Covariante de parámetro de tipo => out
    //El tipo se usa solo como valor de retorno 
    interface IInterfazGenericaVarianteConOut<out T>
    {
        T Get();

        //No esta permitido
        //void Set(T paramTest);

        //Esto arroja un error de compilación
        //void MiMetodo<U>() where U : T; 
    }


    //Contravariante de parámetro de tipo => in
    //Se puede usar como parámetro de método o en una restricción, pero como tipo de retorno
    interface IInterfazGenericaVarianteConIn<in T>
    {
        //No esta permitido
        //T Get();

        void Set(T paramTest);

        void MiMetodo<U>() where U : T;
    }


    //La covarianza y contravarianza se pueden soportar en la misma interfaz , pero se deben hace en parámetros distintos
    interface IInterfaceGenericaVarianteConOutEIn<out T1, in T2>
    {

    }
}
