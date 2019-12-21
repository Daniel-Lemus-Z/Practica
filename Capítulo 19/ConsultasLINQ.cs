using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_19
{
    ////Una consulta LINQ debe empezar por la cláusula from y terminar por la cláusula select o group
    // Entre estas dos  cláusulas de inicio y fin, opcionalmente, puede tener cláusulas where, orderby o join, entre otras

    public class ConsultasLINQ
    {
        public void EjemplosConsultasLINQNumeros()
        {
            List<int> numbers = new List<int>() { 1,2,3,7,1,43,51,23,23,13 };

            IEnumerable<int> filteringQuery =
                from num in numbers
                where num < 3 || num > 7
                select num;

            foreach (var numeros in filteringQuery)
            {
                Console.WriteLine(numeros);
            }
        }

        public void EjemploConsultasLINQCadenas()
        {
            List<string> cadenas = new List<string>() { "Abc", "Bcd", "Cde", "Def", "Efg" };

            IEnumerable<string> filteringQuery =
                from cad in cadenas
                where cad != "Abc" && cad != "Def"
                select cad;
             
            foreach (var c in filteringQuery)
            {
                Console.WriteLine(c);
            }
        }
    }
}
