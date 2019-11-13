using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Campos_y_Propiedades
{
    public class ClaseConPropiedades
    {
        //Las propiedades se parecen a los campos debido a que se pueden acceder a ellas del mismo modo, pero su lógica interna es más parecido a la de los métodos
        //El get y set se llaman descriptores de acceso 
        //Get es para lectura y Set para escritura
        //Los descriptores de acceso se pueden modificar según nuestras necesidades
        public string Nombre { get; set; }
        
        public string Apellido { get; set; }

        public int Identificacion { get; set; }

    }
}
