using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_7.Expresiones_Lambda
{
    public class FuncionesLocales
    {
        private string filename;

        public string Filename
        {
            set
            {
                // Función local, sintaxis normal.
                // string FuncL() { return value ?? this.filename; }

                // Función local, sintaxis de expresión, lambda.
                string FuncL() { return value ?? this.filename; }

                if (this.filename != FuncL())
                {
                    this.filename = value;
                }
            }

        }
    }
}
