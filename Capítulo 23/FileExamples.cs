using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capítulo_23
{
    public class FileExamples
    {
        //Métodos de lectura
        public void ReadAllText()
        {
            string content = File.ReadAllText(@"C:\archivo.txt");
            //Sobrecaga  => permite especificar el tipo de codificación
            string content2 = File.ReadAllText(@"C:\archivo.txt", Encoding.ASCII);
        }

        public void ReadAllLines()
        {
            string[] lines = File.ReadAllLines(@"C:\archivo.txt");
        }

        public void ReadLine()
        {
            IEnumerable<string> lines2 = File.ReadLines(@"C:\archivo.txt");
        }

        public void ReadAllBytes()
        {
            byte[] bytes2 = File.ReadAllBytes(@"C:\archivo.dat");
        }



        //Métodos de escritura
        public void WriteAllText()
        {
            File.WriteAllText(@"C:\archivo.txt", "contenido");

            //Sobrecarga => permite especificar el tipo de codificación
            File.WriteAllText(@"C:\archivo.txt", "Contenido", Encoding.ASCII);
        }

        public void WriteAllLines()
        {
            string[] lines1 = { "Contenido", "del", "archivo" };
            File.WriteAllLines(@"C:\archivo.txt", lines1, Encoding.ASCII);

            List<string> lines2 = new List<string>() { "Contenido", "del", "archivo" };
            File.WriteAllLines(@"C:\archivo.txt", lines2, Encoding.ASCII);

        }

        public void WriteAllBytes()
        {
            byte[] B = { 1, 78, 96, 135 };
            File.WriteAllBytes(@"C:\archivo.dat", B);
        }
        
    }
}
