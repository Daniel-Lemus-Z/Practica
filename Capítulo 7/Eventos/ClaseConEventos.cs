using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_7.Eventos
{
    public class ClaseConEventos1
    {
        public delegate void EventHandler(String s);

        public event EventHandler evento;

        public void OnEvento(String s)
        {
            if (evento != null)
                evento(s);
        }
    }




    public delegate string MiDelegado(string str);
    public class ClaseConEventos2
    {
        event MiDelegado MiEvento;

        public ClaseConEventos2()
        {
            this.MiEvento += new MiDelegado(this.WelcomeUser);
        }

        public string WelcomeUser(string username)
        {
            return "Welcome" + username;
        }
    }
}
