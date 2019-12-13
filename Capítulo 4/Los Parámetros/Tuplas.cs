using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Los_Parámetros
{
    public class Tuplas
    {
        //public static (string nom1, string nom2) SeparaNombre(string nom)
        //{
        //    // "Bogota-Colombia"
        //    string[] data = nom.Split('-');
        //    //return (data[0], data[1]);
        //    //return (nom.Split('-')[0],nom.Split('-')[1]);


        //    (string titulo, string autor, int npaginas)  = GetInfoLibro();
         
        //    Console.Write(titulo);
        //    Console.Write(autor);
        //    Console.Write(titulo);


        //    var x = Tuple.Create<int, int, bool, string, decimal, int, int, Tuple<int, int, bool, int>>(1, 2, true, "ssd", 18M,1,1, Tuple.Create(1,2,true,4));

        //    Tuple<int, int, bool, string, decimal> x2;
           
            

        //}
        public static (string titulo, string autor, int npaginas) GetInfoLibro()
        {
            string titulo = "xx";
            string autor = "yy";
            int npaginas = 100;
            
            return (titulo, autor, npaginas);

            return ("Cien años...", "Gabriel", 700);
            return (titulo: "Cien años...", autor: "Gabriel", npaginas: 700);
        }


    }
}
