using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_19
{
    public static class Extension
    {
        //Un método extendido se debe declarar en una clase estática y se define como un método estático con un primer  argumento de tipo extendido, 
        //precedido de la palabra reservada this.
        public static string Prueba(this string s)
        {
            return s.ToLower();
        }

        //La  clase Enumerable del espacio de nombres  System.Linq define numerosos métodos extendidos.
        //Estos  métodos extendidos se implementan como métodos genéricos.
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }



    }
}
