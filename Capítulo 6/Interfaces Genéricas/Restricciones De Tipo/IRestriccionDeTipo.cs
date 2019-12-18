using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_6.Interfaces_Genéricas.Restricciones_De_Tipo
{
    public class IRestriccionDeTipo
    {
        public void MiMetodo<T> () where T : class
        {
            //El tipo debe ser por referencia
        }

        public void MiMetodo2<T>() where T : struct
        {
            //El tipo debe ser una estructura
        }
        public void MiMetodo3<T>() where T : new ()
        {
            //El tipo debe de tener un constructor sin parámetros
        }
        public void MiMetodo4<T, U>() where U : T
        {
            //El tipo representado por U debe ser idéntico al tipo T
        }
        public void MiMetodo5<T>() where T : ClaseRDT
        {
            //Restricción sobre la clase base del tipo
        }
        public void MiMetodo6<T>() where T : IInterfaceRDT
        {
            //Restricción sobre la interfaz que implementa el tipo
        }
    }
}
