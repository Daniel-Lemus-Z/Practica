using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_19
{
    class Sintaxis
    {
        // Sobreescritura 
        public override string ToString()
        {
            return base.ToString(); 
        }

        
        public void Test()
        {
            // Métos de extensión.
            int x = 2;
            int xn1 = Extension.Negate(x, true, "a");
            int xn2 = x.Negate(true, "a");           
           
            DateTime d = DateTime.Now;
            string sd1 = Extension.ToString2D(d);
            string sd2 = d.ToString2D();
            


            List<MailServer> servers = new List<MailServer>() 
            {
                new MailServer() { Host= "binapps.com", Username="Juan"},                                
                new MailServer() { Host= "wikipedia.com", Username="Pedro"},                                
                new MailServer() { Host= "google.com", Username="Felipe"},                
                new MailServer() { Host= "facebook.com", Username="Isabella"},                
                new MailServer() { Host= "instagram.com", Username="Sukerbe"},
                new MailServer() { Host= "whatsapp.com", Username="Putín"},                                
                new MailServer() { Host= "tinder.com", Username="Madurín"},                
                new MailServer() { Host= "twitter.com", Username="Pajarín"},                
                new MailServer() { Host= "taringa.com", Username="JBalvin"},                                
                new MailServer() { Host= "youtube.com", Username="YBalvin"},                                
                new MailServer() { Host= "microsoft.com", Username="James"},                                
                new MailServer() { Host= "bing.com", Username="Cuadrado"},                                
                new MailServer() { Host= "xbox.com", Username="Chuck"},                                
                new MailServer() { Host= "apple.com", Username="Camilá"},
                new MailServer() { Host= "binchat.com", Username="Vitória"},
                new MailServer() { Host= "wee.com", Username="Frank"}
            };

            IEnumerable<MailServer> serversG = servers;
            
            // Como se hace un foreach a bajo nivel: 
            // Obtener el enumerador
            IEnumerator<MailServer> enu = serversG.GetEnumerator();
            MailServer variableDeIteracion;
            while(enu.MoveNext())
            {
                variableDeIteracion = enu.Current;                  
                // Acá se hace alguna acción con cada elemento.
            }

            // IEnumerable e IEnumerable<T> habilita hacer foreach.
            // var obj1 =  new MailServer() { Host = "binapps.com", Username = "Juan" }; este objeto no impelementa ienumerable por lo tanto no se le puede hacer foreach
            foreach(MailServer variableDeIteracion2 in serversG)
            {

            }





            // Consulta LINQ.
            var queryP = from ms in serversG
                         where ms.Username.ToLower().StartsWith("v")
                         select ms;


            queryP = (from ms in serversG
                      where ms.Username.ToLower().StartsWith("c")
                      select ms).Take(1);
           
            // Cuando y como se ejecuta la consulta.
            // Una consulta no es una colección de elementos. Los resultados se obtienen al iterar a través de la secuencia
            // uno a uno. Los resultados no están creados ni almacenados antes de hacer esto.
            foreach(var s in queryP)
            {
                Debug.WriteLine(s.Username);
            }



            // Consulta LINQ.
            IEnumerable<MailServer> query = from ms in serversG
                                            where ms.Host == "mail.midominio.com"                                                                       
                                            select ms;

            // Prueba de un método de extensión + operador yield return
            // Equivalente a la consulta usando Métodos + Expresiones lambda.
            IEnumerator<MailServer> queryE = serversG.Where2((ms) => ms.Host == "twitter.com");
            while(queryE.MoveNext())
            {
                Debug.WriteLine(queryE.Current.Host);
            }

            IEnumerable<MailServer> queryE2 = serversG.Where3((ms) => ms.Host == "twitter.com");
            foreach (var s in queryE2)
            {
                Debug.WriteLine(s.Username);
            }


            // Equivalente a la consulta usando Métodos + Expresiones lambda.
            IEnumerable<MailServer> query2 = serversG
                .Where((ms) => ms.Host == "mail.midominio.com")
                .OrderBy((ms) => ms.Username)
                .Select((ms) => ms);



            // Métodos de extensión generícos definidos en la clase Enumerable (que contiene la mayor parte de linq)
            IEnumerable<string> queryx = Enumerable.Select(serversG, (ms) => ms.Host);
            // Resultado mapeado a clase definida.
            var queryz = serversG.Select((ms) => new Resultx { Host = ms.Host, Username = ms.Username, Fullx = ms.ToString(), Cosa = 2});
            // Resultado mapeado a tipo anónimo.
            var queryy = serversG.Select((ms) => new { Host = ms.Host, Username = ms.Username, Fullx = ms.ToString(), Cosa = 2});
            
            // Tipos anónimos.
            var ta = new { Host = "goog.gle", Username = "camiturro", Fullx = "fullCamiturro", CosaX = 2, Beta="df0" };
            var tb = new { ACosaX = 2, zBeta="df0" };

            foreach (var anoni in queryy)
            {                
                Debug.WriteLine(anoni.Username);
            }


            // Consulta LINQ conbinada con sintaxis de Métodos + Expresiones lambda.
            var query3 = from ms in serversG.Where((ms) => ms.Username.StartsWith("juan"))
                        where ms.Host == "mail.midominio.com"
                        orderby ms.Username
                        select ms;

        }
    }

    internal class Resultx
    {
        public Resultx()
        {
        }

        public string Host { get; set; }
        public string Username { get; set; }
        public string Fullx { get; set; }
        public int Cosa { get; set; }
    }

    public class MailServer
    {
        public string Host { get; set; }
        public string Username { get; set; }
    }
}
