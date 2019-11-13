using System;
using System.Collections.Generic;
using System.Text;

namespace Capítulo_2_y_3.Enumeraciones
{
    //El atributo flags sirve para que la enumeracion nos devuelva el nombre de sus miembros en lugar del número
    [Flags]
    public enum Enumeración
    {
        //Los miembros de una enumeracion empiezan por cero, pero su valor se puede sobrecargar 
        Lunes = 1,
        Martes = 2,
        Miércoles = 3,
        Jueves = 4,
        Viernes = 5,
        Sábado = 6,
        Domingo = 7,

        //Las enumeraciones también permiten realizar convinaciones durante su declaración
        Trabajo = Lunes | Martes | Miércoles | Jueves | Viernes
    }

    //Las enumeraciones de por si son de tipo int pero se pueden definir con un tipo de dato diferente con la siguiente sintaxis
    //Los tipos permitidos son: byte, sbyte, short, ushort, int, uint, long, ulong
    public enum Enumaración2 : byte
    {
        
    }
}
