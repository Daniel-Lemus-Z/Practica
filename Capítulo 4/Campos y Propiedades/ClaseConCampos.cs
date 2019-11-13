using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Campos_y_Propiedades
{
    public class ClaseConCampos
    {
        //Estos son campos, sob variables de la clase que pueden ser por valor o por referencia 
        public string Nombre;
        public string Apellido;
        public int Identificacion;

        //Los campos se pueden inicializar durante su declaración
        public string Email = "CampoInicializado@gmail.com";

        //La palabra reservada readonly permite especificar que un campo será de solo lectura
        readonly string Direccion;
    }
}
