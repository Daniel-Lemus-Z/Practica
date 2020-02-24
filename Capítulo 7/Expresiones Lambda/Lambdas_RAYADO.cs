using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_7.Expresiones_Lambda_RAYADO
{
    public delegate int Multiplicador(int i);

    public delegate int ValorAbsoluto(int i);

    //Una expresión lambda es un método sin nombre, que sustituye a una instancia de delegado
    //Se pueden usar expresiones lambda en cualquier código que requiera instancias de tipos delegados o de árboles de expresión
    public class Lambdas
    {
        private string _Nombre;
        public string Nombre {
            get => _Nombre;
            set => _Nombre = value;
        }
                       

        public void Multiplicacion2()
        {
            string value = "santi"; 

            // Funciones locales
            string FuncX() => value ?? "No es santi";

            var res = FuncX();


            Func<string>[] F = new Func<string>[3];
            for (int i = 0; i < 3; i++)
            {
                int j = i;
                F[i] = () => j.ToString();
            }
            
            string s = string.Empty;
            foreach (Func<string> f in F)
            {
                s += f();
            }
        }
       

        public void Multiplicacion()
        {       
            Multiplicador M1 = Sum;
            // Inferencia
            Func<int, int> M0 = (x) => 2 * 2;
            M0 = (x) => x * 2;


            int factor = 10;

            // Multilinea
            Action<int> M00 = (x) =>
            {
                // Captura de variables
                factor = 10;
                var res = x * 2 * factor;
                Console.Write(x * 2);
            };

            // Multilinea
            Action<int> M = (x) =>
            {                
                // Captura de variables
                var res = x * 2 * factor;
                Console.Write(x * 2);
            };            

            int i = M0(10);
            Console.WriteLine("Resultado: " + i);
        }

        public int Sum(int x)
        {
            Console.Write(x * 2);
            return x * 2;
        }
        
        public void ValorAbs()
        {
            ValorAbsoluto A = x =>
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


