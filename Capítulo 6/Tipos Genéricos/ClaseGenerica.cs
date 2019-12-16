using Capítulo_6.Interfaces_Genéricas.Covarianza_Y_Contravarianza;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_6.Tipos_Genéricos
{
    //El parámetro T acepta un tipo que se especificara durante la instanciación
    public class ClaseGenerica <T> where T: Clase2 , new() 
    {
        protected List<T> listaG;

        public void AddNew()
        {
            T variable = new T();
            listaG.Add(variable);
        }

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
