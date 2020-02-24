using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capítulo_23
{
    public class StreamWriterExamples
    {
        //Clase StreamWriter

        //Instanciación
        public void Instance()
        {
            //Instancia de un objeto tipo StreamWriter
            StreamWriter streamWriter1 = new StreamWriter(@"C:\archivo.txt");

            //Instancia de un objeto StreamWriter especificando el tipo de codificación
            StreamWriter streamWriter2 = new StreamWriter(@"C:\archivo.txt", false, Encoding.ASCII);
        }

        //Métodos de escritura
        public void WrittingMethods()
        {
            StreamWriter streamWriter1 = new StreamWriter(@"C:\archivo.txt");

            streamWriter1.WriteLine("Contenido");
            streamWriter1.Write('d');
            streamWriter1.Write(new char[] { '1', '\r', '\n' });
            streamWriter1.Write("archivo");
        }
    }
}
