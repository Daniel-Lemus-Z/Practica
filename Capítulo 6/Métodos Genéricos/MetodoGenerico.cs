using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_6.Métodos_Genéricos
{
    public class MetodoGenerico<T>
    {
        //La declaración de los miembros de una clase genérica se hace igual que los de una clase clásica
        T nombre;
        T apellido;
        T direccion;

        //Un método genérico es el que se declara con parámetros de tipo
        public T MetodoG(T param1, T param2)
        {
            //Es imposible devolver un valor null para el descriptor de acceso get, por lo que se usa la palabra reservada default para obtener el valor por defecto del parámetro de tipo
            //Si el parámetro de tipo es por refencia se devuelve un null y para un tipo por valor se devuelve su valor por defecto ejemplo:
            //Si T es int el valor devuelto por defecto será cero
            return default(T);
        }
    }
}
