using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_14
{
    //Una excepción se debe utilizar solo cuando la aplicación necesita una intervención o una operación  
    //específica para poder continuar su ejecución 

    public class ExcepcionPersonalizada : ApplicationException
    {
        public Project Project { get; protected set; }

        public ExcepcionPersonalizada(Project project) : base()
        {

        }

        public ExcepcionPersonalizada(Project project, string mensaje) : base(mensaje)
        {
            this.Project = project;
        }

        public ExcepcionPersonalizada(Project project, string mensaje, Exception innerException) : base (mensaje, innerException)
        {
            this.Project = project;
        }
    }






    public class Project
    {

    }
}
