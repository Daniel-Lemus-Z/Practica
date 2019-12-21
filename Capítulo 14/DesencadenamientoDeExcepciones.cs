using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_14
{
    public class DesencadenamientoDeExcepciones
    {
        private bool hasChanged;

        private int sendDelay;

        public bool HasChanged { get; set; }

        public int SendDelay
        {
            get { return this.sendDelay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El valor debe ser igual o superior a 0.", "Intervalo de envio");
                }
                if (this.sendDelay != value)
                {
                    this.sendDelay = value;
                    this.HasChanged = true;
                }
            }
        }
    }
}
