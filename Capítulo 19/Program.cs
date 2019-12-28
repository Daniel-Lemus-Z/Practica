using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_19
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsultasLINQ consultas = new ConsultasLINQ();
            consultas.EjemplosConsultasLINQNumeros();
            consultas.EjemploConsultasLINQCadenas();



            string s1 = "ABCDEF";
            string s2 = s1.Prueba();
            string s3 = Extension.Prueba(s1);

            Console.WriteLine(s2);


            OperadoresDeConsultas.FiltroWhere("Bogota");
            OperadoresDeConsultas.FiltroOfType();
            OperadoresDeConsultas.FiltroSelectMany();
            OperadoresDeConsultas.FiltroSkipYTake();
            OperadoresDeConsultas.FiltroOderBy();
            OperadoresDeConsultas.FiltroThenBy();
            OperadoresDeConsultas.FiltroGroupBy();
            OperadoresDeConsultas.FiltroJoin();
            //OperadoresDeConsultas.FiltroAgregar();
            //OperadoresDeConsultas.FiltroConvertir();


            ConsultasParalelas.CalcularValorMedio();
            ConsultasParalelas.ParticionarUnaConsulta();
            ConsultasParalelas.AnularConsulta();
            
            Console.ReadKey();
        }
    }
}
