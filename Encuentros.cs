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
      
        //Encuentros genericos
        //Encuentros
        public static void PrimerEncuentro(Jugador p)
        {
            Console.WriteLine("Abres la fuerza con toda tu fuerza, tomas una espada oxidada del piso y avanzas rapidamente hacia tu captor");
            Console.WriteLine("El voltea hacia tu direccion.....");
            Combate(false, "Dum", 3, 10,p);
            Console.ReadKey();
        }
        public static void peleadorArio(Jugador p)
        {
            Console.Clear();
            Console.WriteLine("En tus viajes, un pequeño viajero, de color de piel oscura se acerca");
            Console.WriteLine("-Hey Pleb!");
            Console.WriteLine("Contestame rapidamente, de que color me vez?");
            Console.WriteLine("(A)rio");
            Console.WriteLine("(P)rieto");
            string c = Console.ReadLine();
            c = c.ToLower();
            if(c == "prieto" || c == "p")
            {
                Console.WriteLine("Te arrepentiras de eso!");
                Console.ReadKey();
                Combate(false, "El Doom", 1, 1,p);
                Console.WriteLine("Mientras la pequeña bestia cae al piso, con su ultimo aliento dice");
                Console.WriteLine("mi lineaje ario....");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Porfin alguien que no me miente solo para molestarme");
                Console.WriteLine("Gracias por tu tiempo.......... marron");
                Console.ReadKey();
            }
            
        }
        public static void PeleaGenerica(Jugador p)
        {
            Console.Clear();
            Console.WriteLine("En el transcurso de tu viaje eres atacado por un enemigo!");
            Console.ReadKey();
            Combate(true,"", 0,0,p);

        }
        //Herramientas de encuentro
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
        /// Metodo usado para cualquier combate, establece la vida y daño del oponenete
        /// Muestra un Menu donde el jugador puede ver sus estadisticas y sus opciones de combate
        /// Y permite al jugador elegir que accion tomar durante el combate
        /// </summary>
        /// <param name="random">Utilizado para saber si es un encuentro al azar o predeterminado</param>
        /// <param name="nombreEnemigo">Nombre del enemigo en caso de que sea uno predeterminado </param>
        /// <param name="daño">Daño o ataque del enemigo</param>
        /// <param name="vida">Salud del enemigo</param>
        public static void Combate(bool random, string nombreEnemigo, int daño, int vida,Jugador p)
        {
            string n;
            int d;
            int v;
            int dañoRecibido;
            int dañoInfligido;
            if (random)
            {
                n = ObtenerEnemigo();
                d = p.ObtenerFuerza(p);
                v = p.ObtenerVida(p);
            }
            else
            {
                n = nombreEnemigo;
                d = daño;
                v = vida;
            }
            while (v > 0)
            {
                Console.Clear();
                Console.WriteLine("Puntos de vida del " + n + " : " + v);
                Console.WriteLine("Poder del " + n + " : " + d);
                Console.WriteLine("*==========================*");
                Console.WriteLine("| (A)tacar    (D)efender   |");
                Console.WriteLine("| (C)orrer    (P)ocion     |");
                Console.WriteLine("*==========================*");
                Console.WriteLine("Pociones: " + p.Pociones + " Vida: " + p.Vida);
                string input = Console.ReadLine();
                input = input.ToLower();
                switch (input)
                {
                    case "a":
                    case "atacar":
                        //Atacar. Atacas con toda tu fuerza, infligiendo mucho daño, pero recibiendo mucho daño tambien
                        Console.WriteLine("Sin cuidado alguno cortas con tu espada, en la direccion de tu oponente, el " + n + " logra atacarte tambien");
                        dañoRecibido = r.Next(d - 1, d + 1) - p.Armadura;
                        if (dañoRecibido < 0)
                        {
                            dañoRecibido = 0;
                        }
                        dañoInfligido = r.Next(0, p.PoderDelArma) + r.Next(1, 4);
                        Console.WriteLine("Pierdes " + dañoRecibido + " puntos de vida, e infliges " + dañoInfligido + " puntos de daño al enemigo");
                        p.Vida -= dañoRecibido;
                        v -= dañoInfligido;
                        Console.ReadKey();

                        break;
                    case "d":
                    case "defender":
                        //Defender. Te enfocas en defender, recibes daño disminuido, pero infliges poco daño
                        Console.WriteLine("Mientras que el " + n + " se prepara para atacar, adoptas una postura defensiva ");
                        dañoRecibido = (d - 2) - p.Armadura;
                        if (dañoRecibido < 0)
                        {
                            dañoRecibido = 0;
                        }
                        dañoInfligido = r.Next(0, p.PoderDelArma) + r.Next(1, 2);
                        Console.WriteLine("Pierdes " + dañoRecibido + " puntos de vida, e infliges " + dañoInfligido + " puntos de daño al enemigo");
                        p.Vida -= dañoRecibido;
                        v -= dañoInfligido;
                        Console.ReadKey();
                        break;
                    case "c":
                    case "correr":
                        //Correr.Intentas huir de la batalla
                        if (r.Next(0, 2) == 0)
                        {
                            Console.WriteLine("Intentas huir de la batalla, pero te tropiezas");
                            Console.WriteLine("El " + n + " aprovecha esta oportunidad para atacarte");
                            dañoRecibido = d - p.Armadura;
                            if (dañoRecibido < 0)
                            {
                                dañoRecibido = 0;
                            }
                            Console.WriteLine("Recibes " + dañoRecibido + " puntos de daño y no logras escapar");
                            p.Vida -= dañoRecibido;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Fuga");
                            Console.ReadKey();
                            Console.Clear();
                            
                            return;
                        }

                        break;
                    case "p":
                    case "pocion":
                        //Pocion. Consumir pocion
                        if (p.Pociones == 0)
                        {
                            Console.WriteLine("Buscas desesperadamente en tu bolsa, pero las pociones se han agotado");
                            Console.WriteLine("El " + n + " aprovecha la oportunidad para golpearte");
                            dañoRecibido = d - p.Armadura;
                            if (dañoRecibido < 0)
                            {
                                dañoRecibido = 0;
                            }
                            Console.WriteLine("Recibes " + dañoRecibido + " puntos de daño");
                            p.Vida -= dañoRecibido;
                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine("Coca de piña uma delisia");
                            int pocionPotencia = 5;
                            Console.WriteLine("Recuperas " + pocionPotencia + " puntos de vida");
                            p.Vida += pocionPotencia;
                            p.Pociones -= 1;
                            Console.WriteLine("Igual el " + n + " te va a intentar madrear");
                            dañoRecibido = (d - p.Armadura) - 1;
                            if (dañoRecibido < 0)
                            {
                                dañoRecibido = 0;
                            }
                            Console.WriteLine("Recibes " + dañoRecibido + " puntos de daño");
                            p.Vida -= dañoRecibido;
                            Console.ReadKey();
                        }


                        break;


                }
                if(p.Vida <= 0)
                {
                    Console.WriteLine("Tus puntos de vida han llegado a 0");
                    Console.WriteLine("Fuiste derrotado por el " + n + " , ni modo mi pana, mamaste");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                
            }
            int oro = p.ObtenerMonedas(p);
            Console.Clear();
            Console.WriteLine("Te madreaste al " + n);
            Console.WriteLine("Obtienes " + oro + " monedas de oro ");
            p.Monedas += oro;
            Console.ReadKey();

        }
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
