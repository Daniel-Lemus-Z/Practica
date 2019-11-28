using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_6.Tipos_Genéricos
{
    //El parámetro T acepta un tipo que se especificara durante la instanciación
    public class ClaseGenerica <T>
    {
        protected List<T> listaG;

        //Cuando se instancie esta clase, automaticamente inicara una lista generica con el tipo que se haya especificado 
        public ClaseGenerica()
        {
            //Como List<T> es un tipo por referencia se debe instanciar en el constructor para que no sea null
            this.listaG = new List<T>();
        }
    }

    //Una clase genérica también puede hacer referencia a dos clases
    public class ClaseGenerica2 <T, U>
    {

    }

    //Las clases genéricas se pueden sobrecargar 
    public class ClaseGenerica2 <T, U, V>
    {

    }
}
