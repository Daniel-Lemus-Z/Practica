using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_7.Expresiones_Lambda
{
    public delegate int Multiplicador(int i);

    public delegate int ValorAbsoluto(int i);

    //Una expresión lambda es un método sin nombre, que sustituye a una instancia de delegado
    //Se pueden usar expresiones lambda en cualquier código que requiera instancias de tipos delegados o de árboles de expresión
    public class Lambdas
    {

        public void Multiplicacion()
        {
            Multiplicador M = x => x * 2;
            int i = M(10);
            Console.WriteLine("Resultado: " + i);
        }
        
        public void ValorAbs()
        {

            ValorAbsoluto A = (x) =>
            {
                if (x < 0)
                {
                    return -x;
                }
                else
                {
                    return x;
                }
            };

            int i = A(10);
            int j = A(-10);

            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }
}


