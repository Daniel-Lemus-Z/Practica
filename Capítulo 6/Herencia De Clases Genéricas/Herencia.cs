using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_6.Herencia_De_Clases_Genéricas
{
    //Una clase genérica puede heredar de otra
    public class Padre<T>
    {

    }

    //La clase puede guardar el mismo parámetro de tipo
    public class Hija<T> : Padre<T>
    {

    }

    //La clase que hereda también puede especificar el parámetro de tipo
    public class Hija : Padre<int>
    {

    }

    //La clase que hereda puede introducir nuevos parámetros de tipo
    public class Hija2<T, T2> : Padre<T>
    {

    }

    //El nombre del parámetro de tipo del padre se puede renombrar y usarse en la declaración del tipo hijo 
    public class Hija3<Tx, T2> : Padre<Tx>
    {

    }
}
