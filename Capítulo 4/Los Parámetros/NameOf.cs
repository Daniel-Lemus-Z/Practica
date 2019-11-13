using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Los_Parámetros
{
    public class Software
    {
        public string Version { get; set; }

        public void SetVersion (string version)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            Version = version;
        }

    }
}
