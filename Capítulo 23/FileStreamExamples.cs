using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capítulo_23
{
    public class FileStreamExamples
    {
        public void Examples()
        {
            // La clase FileStream

            FileStream stream = new FileStream(@"C:\archivo.dat",
                                               FileMode.OpenOrCreate,
                                               FileAccess.ReadWrite,
                                               FileShare.None);

            //Los valores de esta enumeración se pueden combinar mediante el operador |
            FileStream stream2 = new FileStream(@"C:\archivo.dat",
                                               FileMode.OpenOrCreate,
                                               FileAccess.ReadWrite,
                                               FileShare.Read |
                                               FileShare.Delete);

            //Los objetos de tipo FileStream también se pueden instanciar a partir de la clase estática File
            FileStream stream3 = File.Open(@"C:\archivo.dat", FileMode.Create);
            FileStream stream4 = File.OpenRead(@"c:\archivo.dat");
            FileStream stream5 = File.OpenWrite(@"c:\archivo.dat");

        }

        //Métodos para leer datos
        public void ReadByte()
        {
            FileStream stream = new FileStream(@"C:\archivo.dat",
                                               FileMode.OpenOrCreate,
                                               FileAccess.ReadWrite,
                                               FileShare.None);

            int nextByte = stream.ReadByte();
        }

        public void Read()
        {
            FileStream stream = new FileStream(@"C:\archivo.dat",
                                               FileMode.OpenOrCreate,
                                               FileAccess.ReadWrite,
                                               FileShare.None);

            byte[] bytes = new byte[10];
            int bytesRead = stream.Read(bytes, 0, 10);
        }



        //Métodos para escribir datos
        public void WriteByte()
        {
            FileStream stream = new FileStream(@"C:\archivo.dat",
                                               FileMode.OpenOrCreate,
                                               FileAccess.ReadWrite,
                                               FileShare.None);

            stream.WriteByte(50);
        }

        public void Write()
        {
            FileStream stream = new FileStream(@"C:\archivo.dat",
                                               FileMode.OpenOrCreate,
                                               FileAccess.ReadWrite,
                                               FileShare.None);

            byte[] bytes = new byte[10];
            bytes = new byte[] { 15, 65, 98, 78, 126 };
            stream.Write(bytes, 0, 5);
        }

    }
}
