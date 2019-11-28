using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_6.Interfaces_Genéricas
{
    public class ClaseGenerica<T> : IInterfaz, IEnumerable<T> where T : ClaseGenerica<T>
    {
        protected List<T> listaG;

        public ClaseGenerica()
        {
            this.listaG = new List<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.listaG.Count; i++)
            {
                yield return this.listaG[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
