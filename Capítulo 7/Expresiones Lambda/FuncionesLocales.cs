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
                string Func() => value ?? this.filename;

                if (this.filename != Func())
                {
                    this.filename = value;
                }
            }

        }
    }
}
