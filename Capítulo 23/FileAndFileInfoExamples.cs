using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capítulo_23
{
    public class FileAndFileInfoExamples
    {
        // File y FileInfo

        public void CreateFileWithClassFile()
        {
            //Creación de un archivo con la clase File
            FileStream fileStream = File.Create(@"C:\archivo.txt");
            //Escribir en el archivo
            fileStream.Dispose();

            //Verificar la existencia de un archivo 
            if (File.Exists(@"C:\archivo.txt"))
            {
                //...
            }
        }

        public void CreateFileWithClassFileInfo()
        {
            //Creación de un archivo con la clase FileInfo
            FileInfo fileInfo = new FileInfo(@"C:\archivo.txt");
            FileStream fileStream2 = fileInfo.Create();
            //Escribir en el archivo
            fileStream2.Dispose();

            //Verificar la existencia de un archivo
            FileInfo fs3 = new FileInfo(@"C:\archivo.txt");
            if (fs3.Exists)
            {
                //...
            }
        }
        
        

        //Para leer o escribir los datos de un archivo ya existente, hay que utilizar los métodos Open, OpenRead, OpenText u OpenWrite
        public void ReadOrWriteFileWithClassFile()
        {
            FileStream fs = File.Open(@"C:\archivo.txt", FileMode.Open);
            //Operaciones sobre el archivo
            fs.Dispose();
        }

        public void ReadOrWriteWithClassFileInfo()
        {
            FileInfo fileInfo2 = new FileInfo(@"C:\archivo.txt");
            FileStream fs2 = fileInfo2.Open(FileMode.Open);
            //operaciones sobre el archivo
            fs2.Dispose();
        }



        //Eliminación de archivos => si el archivo que se intenta eliminar no existe, no se genera ningun tipo de excepción
        public void DeleteFileWithClassFile()
        {
            File.Delete(@"C:\archivo.txt");
        }

        public void DeleteFileWithClassFileInfo()
        {
            FileInfo fs4 = new FileInfo(@"C:\archivo.txt");
            fs4.Delete();
        }



        //Mover o Copiar un archivo => copiar o mover un archivo a una ubicación que contiene un archivo con el mismo nombre, produce una excepción
        public void MoveOrCopyFileWithClassFile()
        {
           
            File.Copy(@"C:\archivo.txt", @"C:\NuevoArchivo");
            File.Move(@"C:\archivo.txt", @"C:\NuevoArchivo");
        }

        public void MoveOrCopyFileWithClassFileInfo()
        {
            FileInfo fs5 = new FileInfo(@"C:\archivo.txt");
            fs5.CopyTo(@"C:\NuevoArchivo.txt");
            fs5.MoveTo(@"C:\NuevoArchivo.txt");
        }




        //Cifrado y Descifrado de archivos
        public void EncryptOrDecryptFileWithClassFile()
        {
            File.Encrypt(@"C:\archivo.txt");
            File.Decrypt(@"C:\archivo.txt");
        }

        public void EncryptOrDecryptFileWithClassFileInfo()
        {
            FileInfo fs6 = new FileInfo(@"C:\archivo.txt");
            fs6.Encrypt();
            fs6.Decrypt();
        }

    }
}
