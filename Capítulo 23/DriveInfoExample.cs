using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capítulo_23
{
    public class DriveInfoExample
    {
        public void DriveInfoLectores()
        {
            // DriveInfo

            //El método GetDrive() devuelve un array de objetos DriveInfo, correspondiente a los lectores de la máquina sobre la que se ejecuta la instrucción
            DriveInfo[] drive = DriveInfo.GetDrives();
            for (int i = 0; i < drive.Length; i++)
            {
                Console.WriteLine(drive[i]);
            }

            //Se puede instanciar pasando como argumento al costructor la letra del lector
            DriveInfo driveC = new DriveInfo("C");
        }
        

    }
}
