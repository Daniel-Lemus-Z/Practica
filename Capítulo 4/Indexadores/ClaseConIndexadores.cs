using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Indexadores
{
    public class ClaseConIndexadores
    {
        string[] Palabras = new string[] { "Hola", "Mundo" };

        public string this[int posicion]
        {
            get { return Palabras[posicion]; }
            set { Palabras[posicion] = value; }
        }

        //Si un tipo declara varios indexadores, debe de haber una declaración diferente 

        //public string this[int posicion]
        //{
        //    get { ... }
        //    set { ... }
        //}

        //public string this[string primeraLetra]
        //{
        //    get { ... }
        //    set { ... }
        //}


        //Un indexador puede declarar varios parámetros
        
        //public string this[int posicion, string primeraLetra]
        //{
        //    get { ... }
        //    set { ... }
        //}
    }
}
