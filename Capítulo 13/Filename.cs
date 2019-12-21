using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_13
{
    public class Filename
    {
        public string FilenameProp
        {
            get { return FilenameProp; }

            protected set
            {
                if (this.FilenameProp != value)
                {
                    //Error de sintaxis
                    //this.FilenameProp = Value;
                }
            }
        }

        //PerfTips
        public static void Run()
        {
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    j++;
                }
            }
        }

        public static void CallerDetected([CallerMemberName] string memberName = null,
            [CallerFilePathAttribute] string filePath = null,
            [CallerLineNumberAttribute] int lineNumber = 0)
        {
            Console.WriteLine("Invocación: " + memberName);
            Console.WriteLine("Ruta:" + filePath);
            Console.WriteLine("Linea:" + lineNumber);
        }
    }
}
