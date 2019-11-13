using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_5.Interfaces
{
    public class Felino : IFelino
    {
        //Si una clase que derive de una interfaz no implementa todos sus miembros, el compilador lanzara un error indicandole que debe implementarlos 
        //Una clase puede derivar de varias interfaces, para esto hay que separar las interfaces por comas ( , )
        
        public virtual string Aceleracion { get; set; }

        //Debido a que la interfaz IFelino hereda de la interfaz IAnimal, se deben implementar los miembros que tenga la interfaz IAnimal de lo contrario, el compilador lanza un error indicando esto
        public int NumeroDePatas { get; set; }
        public string Especie { get; set; }

        public string Correr(int velocidad)
        {
            string resultado = velocidad + "Km/H";
            return resultado;
        }
    }
}
