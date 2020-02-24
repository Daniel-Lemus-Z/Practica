using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capítulo_23
{
    public class StreamReaderExamples
    {
        // clase StreamReader

        //Intanciación
        public void Instance()
        {
            //Instancia de un objeto tipo StreamReader
            StreamReader streamReader = new StreamReader(@"C:\archivo.txt");
            
            //Instancia de un objeto StreamReader especificando el tipo de codificación
            StreamReader streamReader2 = new StreamReader(@"C:\archivo.txt", Encoding.ASCII);

            //Propiedad
            while (!streamReader.EndOfStream)
            {
                string s = streamReader.ReadLine();
            }
        }



        //Métodos de lectura
        public void ReadLine()
        {
            StreamReader streamReader = new StreamReader(@"C:\archivo.txt");

            string line = streamReader.ReadLine();
        }

        public void Read()
        {
            StreamReader streamReader = new StreamReader(@"C:\archivo.txt");

            int nextChar = streamReader.Read();
            //Sobrecarga => permite especificar el número de caracteres que se deben leer y los almacena en un array de tipo char
            char[] chars = new char[3];
            int buffChar = streamReader.Read(chars, 0, 3);
        }

        public void ReadToEnd()
        {
            StreamReader streamReader = new StreamReader(@"C:\archivo.txt");

            string all = streamReader.ReadToEnd();

        }
    }
}
