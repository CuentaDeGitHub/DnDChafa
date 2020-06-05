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
            Console.Clear();
            Console.WriteLine("Al salir de tu escondite, te enfrentas a tu primer desafio");
            Console.WriteLine("Una bestia en muy malas condiciones se encuentra frente de ti");
            Console.WriteLine("Dispuesta a morir por solo un intento de obtener comida y vivir un dia mas");
            Console.ReadKey();
            Combate.Pelea(false, "Muerto de Hambre", 1, 6, p);
        }
        public static void LadronGentil(Jugador p)
        {
            Console.Clear();
            Console.WriteLine("En tus viajes, eres detenido por una figura humana de gran tamaño, tal vez 2 metros");
            Console.WriteLine("-Disculpe buen hombre, lamento molestarlo en este hermoso dia apocaliptico- ");
            Console.WriteLine("-Pero me gustaria pedirle de la manera mas cordial que me entregue la mitad de su dinero-");
            Console.WriteLine("-Porfavor no haga esto mas complicado de lo que tiene que ser");
            Console.WriteLine();
            Console.WriteLine("Parece bastante fuerte...... Entregarle la mitad de tu dinero?");
            Console.WriteLine("Monedas actuales : " + p.Monedas);
            Console.WriteLine("1-Entregarle las monedas");
            Console.WriteLine("2-Jamas! (Pelear)");
            try
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("-Aprecio mucho su comprension y generosidad señor");
                    Console.WriteLine("-Que tenga un buen dia!");
                    Console.WriteLine();
                    Console.WriteLine("Has perdido la mitad de tus monedas");
                    p.Monedas = p.Monedas / 2;
                }
                else if (input == 2)
                {
                    Console.Clear();
                    Console.WriteLine("-Comprendo como se siente");
                    Console.WriteLine("-Pero me veo a obligado a insistir");
                    Combate.Pelea(false, "Asaltante", 3, 15,p);

                }
            }
            catch
            {
                LadronGentil(p);
            }
        }

        public static void peleadorMoribundo(Jugador p)
        {
            Console.Clear();
            Console.WriteLine("En tu exploracion, puedes ver una figura a la distancia");
            Console.WriteLine("Puedes ver que esta gravemente herido, pero se esta aferrando a la vida");
            Console.WriteLine("Puede que no resista mas de un golpe. pero parece que es bastante fuerte");
            Console.WriteLine();
            Console.WriteLine("Atacarlo?");
            Console.WriteLine("1- Atacarlo");
            Console.WriteLine("2- Dejarlo solo");
            try
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Combate.Pelea(false, "Moribundo", 6, 2, p);
                }
                else if (input == 2)
                {
                    Console.Clear();
                    Console.WriteLine("No hay necesidad de atacar a alguien que esta en las ultimas.");
                    Console.WriteLine("Es mejor dejarlo solo");
                }
            }
            catch
            {
                peleadorMoribundo(p);
            }

        }
        public static void EncontrarCajaBuena(Jugador p)
        {
            CajaBuena Cajita = new CajaBuena();
            Console.WriteLine("En tus viajes, encuentras una caja ornamentada en el suelo");
            Console.WriteLine();
            Console.WriteLine("Quieres abrirla?");
            Console.WriteLine("1- Abrirla");
            Console.WriteLine("2- Dejarla cerrada");
            try
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.Clear();
                    Cajita.AbrirCaja(p);
                }
                else if (input == 2)
                {
                    Console.Clear();
                    Cajita.MantenerCajaCerrada(p);
                }
            }
            catch
            {
               EncontrarCajaBuena(p);
            }
        }
        public static void EncontrarCajaMalosa(Jugador p)
        {
            CajaMalosa Cajita = new CajaMalosa();
            Console.WriteLine("En tus viajes, encuentras una caja ornamentada en el suelo");
            Console.WriteLine();
            Console.WriteLine("Quieres abrirla?");
            Console.WriteLine("1- Abrirla");
            Console.WriteLine("2- Dejarla cerrada");
            try
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.Clear();
                    Cajita.AbrirCaja(p);
                }
                else if (input == 2)
                {
                    Console.Clear();
                    Cajita.MantenerCajaCerrada(p);
                }
            }
            catch
            {
                EncontrarCajaMalosa(p);
            }
        }
        /// <summary>
        /// Uno de los encuentros especiales, aqui el combate es opcional
        /// </summary>
        /// <param name="p">El objeto jugador, que incluye su ataque,vida,defensa,pociones,etc</param>
        public static void peleadorArio(Jugador p)
        {
            Console.Clear();
            Console.WriteLine("En tus viajes, una pequeña figura de color marron se te acerca, no parece tener intenciones maliciosas");
            Console.WriteLine("-Hey Pleb - Exclama el pequeño humano a tus pies");
            Console.WriteLine("Todas las personas que me he topado hasta ahora en mis viajes han dicho que me ven de piel oscura");
            Console.WriteLine("Tu de que color me ves?");
            Console.WriteLine("(A)rio");
            Console.WriteLine("(P)rieto");
            string c = Console.ReadLine();
            c = c.ToLower();
            if (c == "prieto" || c == "p")
            {
                Console.WriteLine("Como osas burlarte de mis rasgos arios!");
                Console.ReadKey();
                Combate.Pelea(false, "El Doom", 2, 5, p);
                Console.WriteLine("El pequeño humano cae al piso y con su ultimo aliento dice");
                Console.WriteLine("Ahora quien seguira con el lineaje ario....?");
                Console.WriteLine();
                Console.WriteLine("Te sientes mal al respecto, esto se pudo haber evitado");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gracias por tu respuesta, hay mucha gente que solo quiere molestarme y me llama marron");
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
            switch (r.Next(0, 8))
            {
                case 0:
                case 1:
                case 2:
                    PeleaGenerica(p); 
                    break;
                case 3:
                    peleadorArio(p);
                    break;
                case 4:
                    LadronGentil(p);
                    break;
                case 5:
                    peleadorMoribundo(p);
                    break;
                case 6:
                    EncontrarCajaBuena(p);
                    break;
                case 7:
                    EncontrarCajaMalosa(p);
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
