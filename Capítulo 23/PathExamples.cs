using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capítulo_23
{
    public class PathExamples
    {
        public void ChangeExtensions()
        {
            string result = Path.ChangeExtension(@"C:\archivo.txt", "doc");
            // result = "C:\archivo.doc"
        }

        public void Combine()
        {
            string result2 = Path.Combine(@"c:\Directorio1", "Directorio2", "archivo.txt");
            // result2 = "C:\Directorio1\Directorio2\archivo.txt"
        }

        public void GetDirectoryName()
        {
            string result3 = Path.GetDirectoryName(@"C:\Directorio1\archivo.txt");
            // result3 = "C:\Directorio"
        }

        public void GetExtension()
        {
            string result4 = Path.GetExtension(@"C:\Directorio1\archivo.txt");
            // result4 = ".txt"
        }

        public void GetFileName()
        {
            string result5 = Path.GetFileName(@"C:\archivo.txt");
            // result5 = "archivo.txt"
        }

        public void GetFileNameWithoutExtension()
        {
            string result6 = Path.GetFileNameWithoutExtension(@"C:\archivo.txt");
            // result6 = "archivo"
        }

        public void GetFullPath()
        {
            string result7 = Path.GetFullPath(@"C:\archivo.txt");
        }

        public void GetPathRoot()
        {
            string result8 = Path.GetPathRoot(@"C:\Directorio1\archivo.txt");
            // result8 = "C:\"
        }

        public void GetRandomFileName()
        {
            string result9 = Path.GetRandomFileName();
            // result9 = "0zyso02u.zgv"
        }

        public void GetTempFileName()
        {
            string result10 = Path.GetTempFileName();
            // result10 = "C:\Users\Daniel\AppData\Local\Temp\tmp7032.tmp"
        }

        public void GetTempPath()
        {
            string result11 = Path.GetTempPath();
            // result11 = "C:\Users\Daniel\AppData\Local\Temp\"
        }

        public void HasExtension()
        {
            bool result12 = Path.HasExtension(@"C:\Directorio1\archivo.txt");
            // result12 = true
            bool result13 = Path.HasExtension(@"C:\Directorio1");
            // result13 = false
        }

        public void IsPathRooted()
        {
            bool result14 = Path.IsPathRooted(@"C:\Directorio1");
            // result14 = true
            bool resul15 = Path.IsPathRooted(@"Directorio1");
            // result15 = false
        }
    }
}
