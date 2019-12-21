using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_14
{
    public class IntercepcionYGestionDeExcepciones
    {
        public int GetValueFromArray(int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (System.IndexOutOfRangeException ex)
            {
                System.ArgumentException argEx = new System.ArgumentException("Index is out of range", "index", ex);
                throw argEx;
            }
        }

    }
}
