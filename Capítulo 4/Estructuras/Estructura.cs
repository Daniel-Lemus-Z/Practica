using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_4.Estructuras
{
    public struct Estructura
    {
        double Longitud;
        double Latitud;

        //Esto no se puede hacer en una estructura, no se puede inicializar los campos durante la declaración
        //double Latitud = 1;


        //A las estructuras se les puede declara un constructor
        public Estructura(double lon, double lat)
        {
            this.Longitud = lon;
            this.Latitud = lat;
        }
    }
}
