using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDChafa
{
    public class Encuentros
    {
        static Random r = new Random();
        Combate Combate = new Combate();
        
/// <summary>
/// El primer encuentro forzado para el jugador, despues de la pelea el jugador sera capaz de usar el 
/// menu principal
/// </summary>
/// <param name="p">El objeto jugador, que incluye su ataque,vida,defensa,pociones,etc</param>
        public static void PrimerEncuentro(Jugador p)
        {
            Console.WriteLine("Abres la fuerza con toda tu fuerza, tomas una espada oxidada del piso y avanzas rapidamente hacia tu captor");
            Console.WriteLine("El voltea hacia tu direccion.....");
            Combate.Pelea(false, "Dum", 3, 10,p);
            Console.ReadKey();
        }
        /// <summary>
        /// Uno de los encuentros especiales, aqui el combate es opcional
        /// </summary>
        /// <param name="p">El objeto jugador, que incluye su ataque,vida,defensa,pociones,etc</param>
        public static void peleadorArio(Jugador p)
        {
            Console.Clear();
            Console.WriteLine("En tus viajes, una pequeña figura de color marron se te acerca");
            Console.WriteLine("-Hey Pleb - Exclama el pequeño humano");
            Console.WriteLine("Muchas personas en los demas pueblos no estan reconociendo mis rasgos arios");
            Console.WriteLine("Tu de que color me ves?");
            Console.WriteLine("(A)rio");
            Console.WriteLine("(P)rieto");
            string c = Console.ReadLine();
            c = c.ToLower();
            if(c == "prieto" || c == "p")
            {
                Console.WriteLine("Te arrepentiras de eso!");
                Console.ReadKey();
                Combate.Pelea(false, "El Doom", 1, 1,p);
                Console.WriteLine("Mientras la pequeña bestia cae al piso, con su ultimo aliento dice");
                Console.WriteLine("Ahora quien seguira con el lineaje ario....?");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gracias por no mentirme, hay mucha gente que solo quiere molestarme");
                Console.WriteLine("Puedes quedarte con esto, se que la gente de tu color la pasa duro");
                Console.WriteLine();
                Console.WriteLine("Has obtenido una pocion");
                p.Pociones++;
                Console.ReadKey();
            }
            
        }
        public static void PeleaGenerica(Jugador p)
        {
            Console.Clear();
            Console.WriteLine("En el transcurso de tu viaje eres atacado por un enemigo!");
            Console.ReadKey();
            Combate.Pelea(true,"", 0,0,p);

        }
        /// <summary>
        /// Elige de manera aleatoria un encuentro para el jugador
        /// </summary>
        /// <param name="p">El objeto jugador, que incluye su ataque,vida,defensa,pociones,etc</param>
        public static void EncuentroAleatorio(Jugador p)
        {
            switch (r.Next(0, 2))
            {
                case 0:
                    PeleaGenerica(p);
                    break;
                case 1:
                    peleadorArio(p);
                    break;
            }
        }
   
      
        /// <summary>
        /// Proporciona un nombre para el enemigo de una lista
        /// </summary>
        /// <returns>El nombre del enemigo</returns>
        public static string ObtenerEnemigo()
        {
            switch (r.Next(0, 5))
            {
                case 0:
                    return "Orco";
                case 1:
                    return "Zombie";
                case 2:
                    return "Goblin";
                case 3:
                    return "Vagabundo";
                case 4:
                    return "Humano";
            }
            return "Missigno";
        }
    }
}
