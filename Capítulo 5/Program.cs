using Capítulo_5.Clases_Y_Miembros_Abstractos;
using Capítulo_5.Interfaces;
using Capítulo_5.Polimorfismo;
using System;

namespace Capítulo_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructores Derivados 
            Herencia.ClaseHija ch = new Herencia.ClaseHija();
            ch.xx();
            ch.MetodoBase();
            
            //Esto no esta permitido  
            //ClaseHija este = new ClaseHija(true);



            //Polimorfismo
            //El polimorfismo indica que toca clase derivada puede, implícitamente convertirse en un objeto de su clase base 
            ClaseHijaP chp = new ClaseHijaP();
            ClaseBaseP cbp = chp;

            //Esto no esta permitido => int i = cbp.PropiedadHija; La clase padre no puede accerder a los miembros especificos de la clase hija 

            //La coversión inversa, del tipo padre al tipo hijo, se debe hacer de manera explícita
            chp = (ClaseHijaP)cbp;

            //Si la conversión anterior llega a fallar, el sistema lanzara una excepción, para evitar generar una excepción en la ejecución, se puede hacer la conversión de la siguiente forma:
            chp = cbp as ClaseHijaP;
            //Con esta conversión el objeto tendra null en caso de error

            //Luego, con la siguiente conversión probamos si el objeto no es null para usarlo sin generar errores
            if (chp == null)
            {
                //La conversion se ha realizado con exito 
            }

            //Con esta conversión en caso de error delvovera una excepción del tipo InvalidCastException, que indica precisamente que es la conversión la que ha fallado y no que la variable cbp es null
            int i = ((ClaseHijaP)cbp).PropiedadHija;

            //Con esta conversión en caso de error devolvera una excepción de tipo NullReferenceException, que indica por una parte que que la variable cbp no es del tipo Hija y que la conversion ha dado
            //null, o por otra parte puede decir que la variable cbp es null
            int j = (cbp as ClaseHijaP).PropiedadHija;


            //El operador is nos permite saber de que tipo es un objeto 
            ClaseHijaP chp2 = new ClaseHijaP();
            ClaseBaseP cbp2 = chp2;
            if (cbp2 is ClaseBaseP)
            {
                //True
            }
            if (cbp2 is ClaseHijaP)
            {
                //True
            }
            ClaseBaseP cbp3 = new ClaseBaseP();
            if (cbp3 is ClaseBaseP)
            {
                //True
            }
            if (cbp3 is ClaseHijaP)
            {
                //False
            }




            //Interfaces
            //El pilomorfismo de interfaz implica que cualquier objeto que implemente en una interfaz se puede convertir en el tipo de esta interfaz y los miembros implementados se pueden llamar a partir
            //del objeto convertido 
            //Un objeto del tipo de una interfaz puede hacer referencia a cualquier instancia de objeto cuyo tipo implemente la interfaz

            Guepardo g = new Guepardo();
            g.Aceleracion = "120 Km/H en 3.5 segundos";
            g.Altura = "80 cm";

            IFelino IFe = g;
            IFe.Aceleracion = "100 Km/H en 3.5 segundo";

            Felino Fe = new Felino();
            Fe.Aceleracion = "60 Km/H";

            IFelino IFe2 = Fe;
            IFe2.Aceleracion = "50 Km/H";
        }
    }
}
