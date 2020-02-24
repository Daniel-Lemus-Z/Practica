using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Text;

namespace Capítulo_23
{
    class Program
    {
        static void Main(string[] args)
        {

            DriveInfoExample driveInfo = new DriveInfoExample();
            driveInfo.DriveInfoLectores();


            DirectoryAndDirectoryInfoExamples directoryAndDirectoryInfoExamples = new DirectoryAndDirectoryInfoExamples();
            directoryAndDirectoryInfoExamples.CreateDirectory();
            directoryAndDirectoryInfoExamples.MoveDirectory();
            directoryAndDirectoryInfoExamples.GetSubdirectories();
            directoryAndDirectoryInfoExamples.GetDirectoryInfo();
            directoryAndDirectoryInfoExamples.MoveDirectoryInfo();
            directoryAndDirectoryInfoExamples.GetSubdirectoriesInfo();


            FileAndFileInfoExamples fileAndFileInfoExamples = new FileAndFileInfoExamples();
            fileAndFileInfoExamples.CreateFileWithClassFile();
            fileAndFileInfoExamples.CreateFileWithClassFileInfo();
            fileAndFileInfoExamples.ReadOrWriteFileWithClassFile();
            fileAndFileInfoExamples.ReadOrWriteWithClassFileInfo();
            fileAndFileInfoExamples.DeleteFileWithClassFile();
            fileAndFileInfoExamples.EncryptOrDecryptFileWithClassFileInfo();
            fileAndFileInfoExamples.MoveOrCopyFileWithClassFile();
            fileAndFileInfoExamples.MoveOrCopyFileWithClassFileInfo();
            fileAndFileInfoExamples.EncryptOrDecryptFileWithClassFile();
            fileAndFileInfoExamples.EncryptOrDecryptFileWithClassFileInfo();


            PathExamples pathExamples = new PathExamples();
            pathExamples.ChangeExtensions();
            pathExamples.Combine();
            pathExamples.GetDirectoryName();
            pathExamples.GetExtension();
            pathExamples.GetFileName();
            pathExamples.GetFileNameWithoutExtension();
            pathExamples.GetFullPath();
            pathExamples.GetPathRoot();
            pathExamples.GetRandomFileName();
            pathExamples.GetTempFileName();
            pathExamples.GetTempPath();
            pathExamples.HasExtension();
            pathExamples.IsPathRooted();





            // Siempre se debe usar uno de estos dos métodos al terminar de trabajar con un archivo, en caso contrario quedara bloqueado el archivo y ningún otro proceso se podra hacer sobre él

            //Close => método para cerrar archivos
            //stream.Close();
            //También se puede usar el método Dispose
            //stream.Dispose();




            Console.ReadKey();
        }
    }
}
