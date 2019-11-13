using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Niveles_de_Acceso
{
    //La palabra reservada protected internal solo autoriza el acceso para los otros miembros del tipo o para los que herede de éste en el ensamblado
    class ClaseInternaProtegida
    {
        protected internal string Nombre;
        protected internal string Apellido;
        protected internal int Identifcacion;
    }
}
