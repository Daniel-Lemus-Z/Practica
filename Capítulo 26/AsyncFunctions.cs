using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_26
{
    public class AsyncFunctions
    {
        //Este método es asíncrono, ya que vuelve al método que lo invoca inmediatamente mientras se ejecuta
        public static Task<double> TimeConsumingFunctionAsync()
        {
            return Task.Run(() => TimeConsumingFunctionAsync());
        }


        //La palabra reservada async es un modificador de método que indica al compilador que debe tratar await como una
        //palabra reservada, en lugar de como un identificador

        //Cuando el proceso de ejecución de la aplicación encuentra la palabra reservada await, la ejecución devuelve la
        //llamada de la misma manera que con la palabra reservada yield return en una iteración
        public static async void TimeConsumingFunctionAsync2()
        {
            double resultado = await TimeConsumingFunctionAsync();
            Console.Write("Resultado: ");
            Console.WriteLine(resultado);
        }

        //Métodos asíncronos dentro de una iteración
        public static async void Iteration()
        {
            for (int i = 0; i < 2; i++)
            {
                double resultado = await TimeConsumingFunctionAsync();
                Console.Write("Resultado " + (i + 1) + ": ");
                Console.WriteLine(resultado);
            }
        }
    }
}
