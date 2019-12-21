using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_19
{
    public static class Extension
    {
        public static string Prueba(this string s)
        {
            return s.ToLower();
        }

        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource,bool> predicate)
        {

        }
    }
}
