using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Capítulo_19
{
    public class OperadoresDeConsultas
    {
        public static void FiltroWhere(string ciudad)
        {
            List<string> Cities = new List<string>() { "Manizales", "Medellin", "Pereira", "Bogota" };

            var query = from cities in Cities
                        where cities == ciudad
                        select cities;

            foreach (string ciudades in query)
            {
                Console.WriteLine(ciudades);
            }
        }

        //Una sobrecarga del método Where permite pasar como segundo argumento el índice.
        public static void FiltroWhereIndex(string ciudad, int indexI)
        {
            List<string> Cities = new List<string>() { "Manizales", "Medellin", "Pereira", "Bogota", "Manizales", "Bogota,", "Pereira" };

            //var query = from cities in Cities
            //            where ((cities, index) => cities == ciudad && index < indexIng).
            //            select cities;

            //foreach (string ciudades in query)
            //{
            //    Console.WriteLine(ciudades);
            //}
        }

        //Permite crear un filtro sobre el tipo del objeto.
        public static void FiltroOfType()
        {
            ArrayList lista = new ArrayList();

            lista.Add(12);
            lista.Add("Juan");
            lista.Add(23);
            lista.Add("Pedro");
            lista.Add("Hola");
            lista.Add("Tarantino");
            lista.Add(69);

            var query = lista.OfType<string>().Where(li => li.ToLower().Contains("a"));

            foreach (var L in query)
            {
                Console.WriteLine(L);
            }
        }

        //Permite seleccionar los objetos a partir de varias fuentes y el filtro se puede hacer sobre  estas mismas fuentes.
        public static void FiltroSelectMany()
        {
            PetOwner[] petOwners =
            {
                 new PetOwner {Nombre = "Juan", Pets = new List<string>{"Tom","Jerry"}},
                 new PetOwner {Nombre = "Pedro", Pets = new List<string>{"Bruno", "Jake"}},
                 new PetOwner {Nombre = "Raul", Pets = new List<string>{"Tony", "Coraje"}}
            };

            var query =
                petOwners
                .SelectMany(petOwner => petOwner.Pets, (petOwner, petName) => new { petOwner, petName })
                .Where(ownerAndPet => ownerAndPet.petName.StartsWith("T"))
                .Select(ownerAndPet =>
                    new
                    {
                        Owner = ownerAndPet.petOwner.Nombre,
                        Pet = ownerAndPet.petName
                    }
            );

            foreach (var objeto in query)
            {
                Console.WriteLine(objeto);
            }
        }

        //El método  Skip permite ignorar un  determinado número de elementos. El método Take, por su parte, 
        //permite especificar el número de elementos a  devolver.
        public static void FiltroSkipYTake()
        {
            Players[] players =
            {
                new Players {Nombre = "Carlos", Apellido = "Valderrama", Sueldo = 2000000},
                new Players {Nombre = "Faustino", Apellido = "Asprilla", Sueldo = 3000000},
                new Players {Nombre = "Freddy", Apellido = "Rincon", Sueldo = 1000000},
                new Players {Nombre = "René", Apellido = "Higuita", Sueldo = 4000000},
                new Players {Nombre = "Samuel", Apellido = "Umtiti", Sueldo = 5000000},
                new Players {Nombre = "Carles", Apellido = "Puyol", Sueldo = 3000000},
                new Players {Nombre = "Ronaldinho", Apellido = "Gaucho", Sueldo = 1000000},
                new Players {Nombre = "Ronaldo", Apellido = "Nazario", Sueldo = 6000000},
                new Players {Nombre = "Diego", Apellido = "Maradona", Sueldo = 7000000},
                new Players {Nombre = "Samuel", Apellido = "Eto'o", Sueldo = 10000000},
            };

            var query = (from p in players
                         orderby p.Nombre
                         select p).Skip(5).Take(3);

            foreach (var soccer in query)
            {
                Console.WriteLine(soccer.Nombre);
            }
        }

        //Permite ordenar los elementos siguiendo el o los criterios  especificados.
        //El método OrderByDescending permite ordenar el resultado en el orden inverso al método OrderBy.
        public static void FiltroOderBy()
        {
            Players[] players =
            {
                new Players {Nombre = "Carlos", Apellido = "Valderrama", Sueldo = 2000000},
                new Players {Nombre = "Faustino", Apellido = "Asprilla", Sueldo = 3000000},
                new Players {Nombre = "Freddy", Apellido = "Rincon", Sueldo = 1000000},
                new Players {Nombre = "René", Apellido = "Higuita", Sueldo = 4000000},
                new Players {Nombre = "Samuel", Apellido = "Umtiti", Sueldo = 5000000},
                new Players {Nombre = "Carles", Apellido = "Puyol", Sueldo = 3000000},
                new Players {Nombre = "Ronaldinho", Apellido = "Gaucho", Sueldo = 1000000},
                new Players {Nombre = "Ronaldo", Apellido = "Nazario", Sueldo = 6000000},
                new Players {Nombre = "Diego", Apellido = "Maradona", Sueldo = 7000000},
                new Players {Nombre = "Samuel", Apellido = "Eto'o", Sueldo = 10000000},
            };

            var query = from p in players
                        orderby p.Sueldo 
                        select p;

            foreach (var lista in query)
            {
                Console.WriteLine(lista.Sueldo);
            }
        }

        //Los métodos ThenBy y  ThenByDescending permiten definir sentencias de ordenación en caso de que la  primera ordenación 
        //definida por los métodos OrderBy o OrderByDescending, devuelva elementos idénticos.
        public static void FiltroThenBy()
        {
            string[] frutas = { "Mango", "Naranja", "Papaya", "Piña",
                      "Fresa", "Mandarina", "Guanabana", "Uva" };

            IEnumerable<string> query =
                frutas.OrderBy(f => f.Length).ThenBy(f => f);

            foreach (string f in query)
            {
                Console.WriteLine(f);
            }
        }

        //Los resultados se pueden agrupar mediante el método GroupBy, utilizando para ello el valor de una clave. 
        //El  método devuelve un grupo de objetos anónimos creado.
        public static void FiltroGroupBy()
        {
            List<Pet> petsList =
                new List<Pet>{ new Pet { Nombre="Jake", Edad=5.5 },
                new Pet { Nombre="Boots", Edad=5.9 },
                new Pet { Nombre="Whiskers", Edad=4.5 },
                new Pet { Nombre="Zeus", Edad=4.5 },
                new Pet { Nombre="Poseidon", Edad=3.5 },
                new Pet { Nombre="Hades", Edad=3.2 },
                new Pet { Nombre="Daisy", Edad=2.3 } };

            var query = petsList.GroupBy(
                p => Math.Floor(p.Edad),
                p => p.Edad,
                (baseAge, ages) => new
                {
                    Key = baseAge,
                    Count = ages.Count(),
                    Min = ages.Min(),
                    Max = ages.Max()
                });

            foreach (var result in query)
            {
                Console.WriteLine("\nGrupo de edad: " + result.Key);
                Console.WriteLine("Numero de mascotas en el grupo: " + result.Count);
                Console.WriteLine("Minima edad: " + result.Min);
                Console.WriteLine("Maxima edad: " + result.Max);
            }
        }

        //Permite establecer una relación basada en un criterio específico entre dos fuentes.
        public static void FiltroJoin()
        {
            List<Jugador> titulares = new List<Jugador> { new Jugador {NombreCamiseta = "Pique", Dorsal = 3, Equipo = "Barcelona", IdEquipo = 1 }, 
                new Jugador {NombreCamiseta = "Busquets", Dorsal = 5, Equipo = "Barcelona", IdEquipo = 1 }, 
                new Jugador {NombreCamiseta = "Messi", Dorsal = 10, Equipo = "Barcelona", IdEquipo = 1 }, 
                new Jugador {NombreCamiseta = "Dybala", Dorsal = 10, Equipo = "Juventus", IdEquipo = 2 }, 
                new Jugador {NombreCamiseta = "Cristiano", Dorsal = 7, Equipo = "Juventus", IdEquipo = 2 }, 
                new Jugador {NombreCamiseta = "Cuadrado", Dorsal = 16, Equipo = "Juventus", IdEquipo = 2 }
            };


            List<Jugador> suplentes = new List<Jugador> {new Jugador {NombreCamiseta = "Aleña", Dorsal = 34, Equipo = "Barcelona", IdEquipo = 1 },
                new Jugador {NombreCamiseta = "Umtiti", Dorsal = 4, Equipo = "Barcelona", IdEquipo = 1 },
                new Jugador {NombreCamiseta = "Suarez", Dorsal = 9, Equipo = "Barcelona", IdEquipo = 1 },
                new Jugador {NombreCamiseta = "Higuain", Dorsal = 9, Equipo = "Juventus", IdEquipo = 2 },
                new Jugador {NombreCamiseta = "D.Costa", Dorsal = 11, Equipo = "Juventus", IdEquipo = 2 },
                new Jugador {NombreCamiseta = "Buffon", Dorsal = 77, Equipo = "Juventus", IdEquipo = 2 } 
            };

            var query = from equipoT in titulares
                        join equipoS in suplentes
                        on equipoT.IdEquipo equals equipoS.IdEquipo
                        select new {titulares = equipoT, suplentes = equipoS};

            foreach (var item in query)
            {
                var equipoT = item.titulares;
                var equipoS = item.suplentes;
                string resultado = equipoT.NombreCamiseta + "  " + equipoS.NombreCamiseta;
                Console.WriteLine(resultado);

            }           
        }

        public static void FiltroAgregar()
        {
            //List<Jugador> titulares = new List<Jugador> { new Jugador {NombreCamiseta = "Pique", Dorsal = 3, Equipo = "Barcelona", IdEquipo = 1 },
            //    new Jugador {NombreCamiseta = "Busquets", Dorsal = 5, Equipo = "Barcelona", IdEquipo = 1 },
            //    new Jugador {NombreCamiseta = "Messi", Dorsal = 10, Equipo = "Barcelona", IdEquipo = 1 },
            //    new Jugador {NombreCamiseta = "Dybala", Dorsal = 10, Equipo = "Juventus", IdEquipo = 2 },
            //    new Jugador {NombreCamiseta = "Cristiano", Dorsal = 7, Equipo = "Juventus", IdEquipo = 2 },
            //    new Jugador {NombreCamiseta = "Cuadrado", Dorsal = 16, Equipo = "Juventus", IdEquipo = 2 }
            //};

            //var query = from equipo in titulares
            //            group equipo by equipo.IdEquipo into e
            //            select new
            //            {
            //                IdEquipo = e.Key,
            //                Count = e.Count()
            //            };

            //foreach (var equipo in query)
            //{
            //    equipo.IdEquipo.ToString();
            //}

        }                
             
        public static void FiltroConvertir()
        {

        }

    }

















    public class PetOwner
    {
        public string Nombre { get; set; }

        public List<string> Pets { get; set; }
    }

    public class Players
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Sueldo { get; set; }
    }

    public class Pet
    {
        public string Nombre { get; set; }
        public double Edad { get; set; }
    }

    public class Jugador
    {
        public string NombreCamiseta { get; set; }
        public int Dorsal { get; set; }
        public string Equipo { get; set; }
        public int IdEquipo { get; set; }
    }
        
}
