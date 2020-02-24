using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
            ArrayList listax = new ArrayList();
            listax.Add(new MailServer() { });
            listax.Add(new MailServer() { });
            listax.Add(new MailServer() { });

            foreach(var ms in listax.Cast<MailServer>())
            {
                //Debug.WriteLine(
            }


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

            // Con sintaxis de consulta.
            var query2 = from pOwner in petOwners
                         from p in pOwner.Pets
                         where pOwner.Nombre == "Pedro" && p == "Bruno"
                         select pOwner;
            
            // Con sintaxis de métodos
            var query =
                petOwners
                .SelectMany(pOwner => pOwner.Pets, (petOwner, petName) => new { petOwner, petName, Cosa = 5 })
                .Where(ownerAndPet => ownerAndPet.petOwner.Nombre == "Pedro" && ownerAndPet.petName == "Bruno")
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

            // El TakeWhile a diferencia de Where, para hasta que la condición sea falsa, y no retorna
            // más elementos incluso si cumplen con la condición.
            // Where retorna todos los elementos que cumplan las condición.

            var query2 = players
                .SkipWhile((p) => p.Apellido.StartsWith("H"))
                .TakeWhile((p) => p.Nombre.Length < 10);

            foreach (var soccer in query2)
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


            var query2 = from p in petsList
                         group p by new { p.Edad, p.Nombre } into grupex
                         select new
                         {
                             key = grupex.Key,
                             elementos = grupex
                         };


            foreach (var result in query2)
            {
                
                Console.WriteLine("\nGrupo de edad: " + result.key.Edad);
                Console.WriteLine("Numero de mascotas en el grupo: " + result.elementos.Count());
            }

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
            List<Jugador> titulares = new List<Jugador> { 
                new Jugador {NombreCamiseta = "Pique", Dorsal = 3, Equipo = "Barcelona", IdEquipo = 1,  DorsalSuplente=4 }, 
                new Jugador {NombreCamiseta = "Busquets", Dorsal = 5, Equipo = "Barcelona", IdEquipo = 1 }, 
                new Jugador {NombreCamiseta = "Messi", Dorsal = 10, Equipo = "Barcelona", IdEquipo = 1, DorsalSuplente=9 }, 
                new Jugador {NombreCamiseta = "Dybala", Dorsal = 10, Equipo = "Juventus", IdEquipo = 2 }, 
                new Jugador {NombreCamiseta = "Cristiano", Dorsal = 7, Equipo = "Juventus", IdEquipo = 2 }, 
                new Jugador {NombreCamiseta = "Cuadrado", Dorsal = 16, Equipo = "Juventus", IdEquipo = 2 }
            };


            List<Jugador> suplentes = new List<Jugador> {
                new Jugador {NombreCamiseta = "Aleña", Dorsal = 34, Equipo = "Barcelona", IdEquipo = 1 },
                new Jugador {NombreCamiseta = "Umtiti", Dorsal = 4, Equipo = "Barcelona", IdEquipo = 1 },
                new Jugador {NombreCamiseta = "Suarez", Dorsal = 9, Equipo = "Barcelona", IdEquipo = 1 },
                new Jugador {NombreCamiseta = "Higuain", Dorsal = 9, Equipo = "Juventus", IdEquipo = 2 },
                new Jugador {NombreCamiseta = "D.Costa", Dorsal = 11, Equipo = "Juventus", IdEquipo = 2 },
                new Jugador {NombreCamiseta = "Buffon", Dorsal = 77, Equipo = "Juventus", IdEquipo = 2 } 
            };

            string[] sec1 = { "hola", "pana" };
            string[] sec2 = { "hola", "x"};
            
            var resU = sec1.Union(sec2).Except(sec1.Intersect(sec2)); // pana
            var resU2 = sec1.Concat(sec2);

            var resList = resU.ToList();

            var list2 = new List<string>(resU);

            // imprimiendo... hola, pana, hola, pana -> Daniel L, Fabio
            // imprimiendo... hola, hola, pana, pana -> Deivi
            // imprimiendo... hola, pana             -> Cami

            var resUnion = (from jT in titulares where jT.IdEquipo == 1
                            select new { titulare = jT, nomTitular = jT.NombreCamiseta, suplente = jT, nomSuplente =(string)null})
                            .Union(from jS in suplentes where jS.IdEquipo == 1
                                  select new { titulare = jS, nomTitular = (string)null, suplente = jS, nomSuplente = jS.NombreCamiseta });
            
            var query = from jT in titulares
                        join jS in suplentes
                        on jT.DorsalSuplente equals jS.Dorsal where jT.IdEquipo == jS.IdEquipo 
                        select new {titulare = jT, nomTitular=jT.NombreCamiseta, suplente = jS, nomSuplente=jS.NombreCamiseta};

            foreach (var item in query)
            {
                var jugadorT = item.titulare;
                var jugadorS = item.suplente;
                string resultado = jugadorT.NombreCamiseta + "  " + jugadorS.NombreCamiseta;
                Console.WriteLine(resultado);

            }           
        }

        public static void FiltroAgregar()
        {
            List<Jugador> titulares = new List<Jugador> {
                new Jugador {NombreCamiseta = "Pique",     Dorsal = 3,   Goles=1, Equipo = "Barcelona", IdEquipo = 1 },
                new Jugador {NombreCamiseta = "Busquets",  Dorsal = 5,   Goles=2, Equipo = "Barcelona", IdEquipo = 1 },
                new Jugador {NombreCamiseta = "Messi",     Dorsal = 10,  Goles=5, Equipo = "Barcelona", IdEquipo = 1 },
                new Jugador {NombreCamiseta = "Dybala",    Dorsal = 10,  Goles=2, Equipo = "Juventus", IdEquipo = 2 },
                new Jugador {NombreCamiseta = "Cristiano", Dorsal = 7,   Goles=3, Equipo = "Juventus", IdEquipo = 2 },
                new Jugador {NombreCamiseta = "Cuadrado",  Dorsal = 16,  Goles=2, Equipo = "Juventus", IdEquipo = 2 }
            };

            var query = from j in titulares
                        group j by "x" into g
                        select new
                        {
                            IdEquipo = g.Key,
                            VarA = g.Average((ju) => ju.Goles)
                        };                       

            foreach (var equipo in query)
            {
                equipo.IdEquipo.ToString();
            }

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
        public doubl Goles { get; set; }
        public string Equipo { get; set; }
        public int IdEquipo { get; set; }
        public int? DorsalSuplente { get; set; }
    }
        
}
