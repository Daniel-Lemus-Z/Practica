using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_7.Expresiones_Lambda
{
    public class DelegadosGenericos
    {
        //Estos delegados devuelven cualquier tipo de objeto y aceptan hasta 16 argumentos del mismo o diferente tipo
        //Los delegados genéricos no tienen que ser declaradosfuertemente tipados

        public delegate void Del<T>(T item);

        //Las expresiones lambda son las que más se utilizan con los delegados genéricos Func y Action: 
        Func<int, int> F = x => x * 2;

        public delegate TResult Func<out TResult>();
        public delegate TResult Func<in T, out TResult>(T arg);
        public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);


        public delegate void Action();
        public delegate void Action<in T>(T arg);
        public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);

    }
}
