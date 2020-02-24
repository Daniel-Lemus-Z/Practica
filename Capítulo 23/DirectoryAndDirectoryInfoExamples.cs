using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capítulo_23
{
    public class DirectoryAndDirectoryInfoExamples
    {
        // Directory y DirectoryInfo

        public void CreateDirectory()
        {
            //Creación de un directorio con la clase Directory
            Directory.CreateDirectory(@"C:\directorio");

            //Verificación de la existencia de un directorio con la clase Directory
            if (Directory.Exists(@"C:\directorio"))
            {
                Directory.Delete(@"C:\directorio");
            }
        }

        public void MoveDirectory()
        {
            //Mover un directorio 
            if (Directory.Exists(@"C:\directorio"))
            {
                Directory.Move(@"C:\directorio", @"C:\NuevoDirectorio");
            }
        }

        public void GetSubdirectories()
        {
            //Obtener subdirectorios
            string[] dirs = Directory.GetDirectories(@"C:\directorio");
            IEnumerable<string> enumDirs = Directory.EnumerateDirectories(@"C:\directorio");
            //Sobrecargas 
            // ? => reemplaza un único caracter
            string[] dirsS = Directory.GetDirectories(@"C:\directorio", "m?o", SearchOption.TopDirectoryOnly);
            // * => reeplaza uno o varios caracteres
            string[] dirsS2 = Directory.GetDirectories(@"C:\directorio", "m?*", SearchOption.AllDirectories);
        }

        public void GetDirectoryInfo()
        {
            //Creación de un directorio con la clase DirectoryInfo
            DirectoryInfo directory = new DirectoryInfo(@"C:\directorio");
            directory.Create();

            //verificación de la existencia de un directorio con la clase DirectoryInfo
            if (directory.Exists)
            {
                directory.Delete();
            }
        }

        public void MoveDirectoryInfo()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\directorio");

            //Mover un directorio
            DirectoryInfo directoryMove = new DirectoryInfo(@"C:\directorio");
            if (directoryMove.Exists)
            {
                directory.MoveTo(@"C:\NuevoDirectorio");
            }
        }

        public void GetSubdirectoriesInfo()
        {
            //Obtener subdirectorios
            DirectoryInfo directoryObtenerSub = new DirectoryInfo(@"C:\directorio");
            DirectoryInfo[] dirsInfo = directoryObtenerSub.GetDirectories();
            IEnumerable<DirectoryInfo> enumDirsInfo = directoryObtenerSub.EnumerateDirectories();
        }

    }
}
