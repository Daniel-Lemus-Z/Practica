using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Capítulo_7.Program;

namespace Capítulo_7.Delegados.Delegados_Genéricos_RAYADO
{

    //Un delegado puede contener parámetros de tipo genérico, en este caso, el tipo de indicara durante su instanciación 
    public delegate T Calculo<T>(T i, T j);
    public delegate int CalculoNG(int i, int j);

    public class Clase1DG
    {
        public Clase1DG(int i, int j)
        {
            // Se hace uso del delegado genérico, volviéndolo un tipo Concreto.
            Calculo<int> C = new Calculo<int>(Adicion);
            Calculo<string> S = new Calculo<string>(AdicionG<string, string, string>);
            var res = S.Invoke("Al", "Pha");

            CalculoNG C2 = new CalculoNG(AdicionG<int, int, int>);

            int resultado = C.Invoke(i, j);


            //System.Func<>
            //System.Action<

            MyFuncI ci = MetodoCompatibleConFuncI;
            MyFuncS cs = MetodoCompatibleConFuncS;
            MyFuncB cb = MetodoCompatibleConFuncB;

            System.Func<int> ci2 = MetodoCompatibleConFuncI;
            System.Func<string> cs2 = MetodoCompatibleConFuncS;
            System.Func<int, int, bool> cb2 = MetodoCompatibleConFuncB;
            System.Func<int, int, string, bool> cx2 = MetodoCompatibleConFuncB;
                        
            MyFunc<System.Exception, string, bool, bool> cxF = MetodoCompatibleConFuncB2;

            // Inferencia de tipos. métodos, o firmas.
            System.Action a1 = HaceAlgo;
            System.Action<int> a2 = HaceAlgo;
            System.Action<string, Exception> a3 = HaceAlgo;
        }

        public void HaceAlgo()
        {           
        }

        public void HaceAlgo(int i)
        {
        }

        public void HaceAlgo(string i, Exception ex)
        {
        }




        public delegate int MyFuncI();
        public delegate String MyFuncS();
        public delegate bool MyFuncB(int i, int j);

        public delegate TResult MyFunc<T, T2, T3, TResult>();

        public int MetodoCompatibleConFuncI()
        {
            return 0;
        }
        public string MetodoCompatibleConFuncS()
        {
            return "hola";
        }

        public bool MetodoCompatibleConFuncB2() 
        {
            return false;
        }

        public bool MetodoCompatibleConFuncB(int i, int j)
        {
            return false;
        }

        public bool MetodoCompatibleConFuncB(int i, int j, string s)
        {
            return false;
        }


        public int Adicion (int i, int j)
        {
            return i + j;
        }


        public TResult AdicionG<T, U, TResult>(T i, U j)
        {
            return default(TResult);
        }




        public string AdicionString(string i, string j)
        {
            return i + j;
        }
    }
}
