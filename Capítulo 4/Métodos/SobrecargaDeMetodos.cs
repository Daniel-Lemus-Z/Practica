using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Métodos
{
    public class SobrecargaDeMetodos
    {
        //La sobrecargarsignifica que varias métodos pueden tener el mismo nombre desde que sus declaraciones sean diferentes 
        public int Suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Suma(int numero1, int numero2, int numero3)
        {
            return numero1 + numero2 + numero3;
        }

        public string Suma(string cadena1, string cadena2)
        {
            string rta = cadena1 + " " + cadena2;
            return rta;
            //Sumax(n1: 4, n2: "hola");
        }


        public void Sumax(int n1, string n2)
        {

        }

        public void Sumax(string n2, int n1)
        {

        }

    }
}
