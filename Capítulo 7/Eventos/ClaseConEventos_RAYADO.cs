using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capítulo_7.Eventos_RAYADO
{
    public delegate bool MyFuncBHandler(int i, int j);
     
    public delegate void NominaEventHandler(ClaseConEventos1 s, NominaEventArgs e);

    public class ClaseConEventos1
    {
        public string NombreX;

        public ClaseConEventos1(string nombreX)
        {
            NombreX = nombreX;
        }


        public MyFuncBHandler ETemp;
        public void OnEventoDeleg()
        {
            // if (ETemp != null) ETemp.Invoke(2, 2);
            ETemp?.Invoke(2, 2);
        }



        int _total;
        public void SetTotalNomina(int total)
        {
            _total = total;
            if(total > 20_000_000)
            {
                OnTopeNominaSuperado(total - 20_000_000);
            }
        }

        
        public event System.EventHandler TopeNominaSuperadoG;
        public event System.EventHandler<NominaEventArgs> TopeNominaSuperadoG2;

        public event NominaEventHandler TopeNominaSuperado;
        public void OnTopeNominaSuperado(int desfase)
        {
            //Siempre hay que asegurarse de que el evento tiene suscriptor (que no sea null), ya que si intentamos desencadenar
            //un evento sin suscriptor, se producirá una excepción
            //if (evento != null) evento.Invoke(s);
            var e = new NominaEventArgs(desfase, "Fulano de tal");
            TopeNominaSuperadoG2?.Invoke(this, e);
        }
    }

    public class NominaEventArgs : EventArgs
    {
        public int Desfase { get; }
        public string NombreEmpleado { get; }
        public NominaEventArgs(int desfase, string nombreEmpleado)
        {
            Desfase = desfase;
            NombreEmpleado = nombreEmpleado;
        }
    }





    public class TestEventos
    {
        ClaseConEventos1 cce;

        public void TestEvento()
        {
            // Difusor
            // El difusor tiene la lista de métodos (osea la variable de tipo delegado, o el delegado)
            // El difusor generalmente decide cuándo se invoca el delegado.
            cce = new ClaseConEventos1("Ejemplo-Nomina");
            cce.TopeNominaSuperado += CCE_TopeNominaSuperado; // Suscripción

            cce.SetTotalNomina(10_000_000);
            // cosas..
            cce.SetTotalNomina(11_000_000);
            //
            cce.SetTotalNomina(21_000_000);
                       
            cce.TopeNominaSuperado -= CCE_TopeNominaSuperado; // DesSuscripción
            cce = null;
            cce = new ClaseConEventos1("x");

        }

        public void CCE_TopeNominaSuperado(object s, NominaEventArgs e)
        {
            var cTemp = (ClaseConEventos1)s;
            Debug.WriteLine("Objeto que lanzó el evento: " + s.ToString());
            Console.WriteLine($"Paila... se superó la nómina en: {e.Desfase}, por culpa de {e.NombreEmpleado}");
        }




        public void TestDelegado()
        {
            // Difusor
            // El difusor tiene la lista de métodos (osea la variable de tipo delegado, o el delegado)
            // El difusor generalmente decide cuándo se invoca el delegado.
            ClaseConEventos1 cce = new ClaseConEventos1("x");
            cce.ETemp += MetodoP;
            cce.ETemp += MetodoPX;


            cce.ETemp -= MetodoP;
            cce.ETemp -= MetodoPX;
            cce = null;

            cce = new ClaseConEventos1("x");

        }

        public bool MetodoP(int i, int j)
        {
            return false;
        }

        public bool MetodoPX(int i, int j)
        {
            return false;
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
            return "Welcome  " + username;
        }
    }



}
