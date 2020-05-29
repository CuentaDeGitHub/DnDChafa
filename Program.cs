using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDChafa
{
    class Program
    {
        public static Jugador JugadorActual = new Jugador("",10,100,1,0,5,1,0);
        public static bool loopPrincipal = true;
        static void Main(string[] args)
        {
            Comenzar();
            Encuentros.PrimerEncuentro(JugadorActual);
            while (loopPrincipal)
            {
                Encuentros.EncuentroAleatorio(JugadorActual);
            }
        }
        static void Comenzar()
        {
            Console.WriteLine("Bienvenido a la mazmorra");
            Console.WriteLine("Nombre del personaje:");
            JugadorActual.Nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Despiertas en un cuarto oscuro, te sientes mareado y tienes problemas recordando cosas sobre tu pasado");

            if (JugadorActual.Nombre == "")
            {
                Console.WriteLine("No recuerdas ni tu propio nombre");
            }
            else
            {
                Console.WriteLine("Sabes que tu nombre es " + JugadorActual.Nombre);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Deambulas en la oscuridad sin rumbo, hasta que encuentras una manecilla de puerta");
            Console.WriteLine("Al intentar abrirla puedes sentir un poco de resistencia, eventualmente el candado oxidado se rompe sin mucho problema");
            Console.WriteLine("Puedes ver a tu captor dandote la espalda mas alla de la puerta");
            Console.ReadKey();


        }
            
    }
}
