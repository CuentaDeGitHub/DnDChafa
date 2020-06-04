using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDChafa
{
    class Combate
    {
        static Random r = new Random();
        public static void Pelea(bool random, string nombreEnemigo, int daño, int vida, Jugador p)
        {
            string n;
            int d;
            int v;
            int dañoRecibido;
            int dañoInfligido;
            if (random)
            {
                n = "";
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
                            Console.WriteLine("Usas tu pocion de curacion");
                            int pocionPotencia = 5;
                            Console.WriteLine("Recuperas " + pocionPotencia + " puntos de vida");
                            p.Vida += pocionPotencia;
                            p.Pociones -= 1;
                            Console.WriteLine("El " + n + " aprovecha el momento para atacarte");
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
                if (p.Vida <= 0)
                {
                    Console.WriteLine("Tus puntos de vida han llegado a 0");
                    Console.WriteLine("Fuiste derrotado por el " + n);
                    Historia.Imprimir("Has muerto....");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

            }
            int oro = p.ObtenerMonedas(p);
            Console.Clear();
            Console.WriteLine("Has derrotado al " + n);
            Console.WriteLine("Obtienes " + oro + " monedas de oro ");
            p.Monedas += oro;
            p.Exp = p.Exp + 1;
            Console.ReadKey();

        }
    }
}
