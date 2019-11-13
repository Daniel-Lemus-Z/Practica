using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Clases_Parciales
{
    public partial class ClaseParcial2 : ClaseParcial1
    {
        public ClaseParcial2(string nombre, string apellido, int identificacion)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Identificacion = identificacion;
        }

        public void LlamarMetodo()
        {
            MetodoLlamado();
        }
    }
}
