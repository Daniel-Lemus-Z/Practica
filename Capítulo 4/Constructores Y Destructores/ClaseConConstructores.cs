using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Constructores_Y_Destructores
{
    public class ClaseConConstructores
    {
        public string Nombre;
        public string Apellido;

        //Los contructores son métodos especificos que permiten suministrar el código de inicialización de los objetos

        //Pueden existir constructores vacios (sin parámetros), de por si cuando se genera una clase esta contiene un constructores vacio definido implícitamente, pero una vez creemos un constructor
        //este desparace y lo debemos crear nosotros
        public ClaseConConstructores()
        {

        }

        //Los contructores se pueden sobrecargar
        public ClaseConConstructores(string nom, string ape)
        {
            this.Nombre = nom;
            this.Apellido = ape;
        }

        //Los contructores se pueden declarar en forma de expresion 
        public ClaseConConstructores(string nom) => Nombre = nom;
    }
}
