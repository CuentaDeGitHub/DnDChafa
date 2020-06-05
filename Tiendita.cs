using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDChafa
{
    public class Tiendita
    {
      
    /// <summary>
    /// Interfaz que permite al usuario comprar pociones y mejoras para su armadura y arma
    /// </summary>
    /// <param name="p">Objeto del personaje, los precios son calculados en base a las mejoras que tengas</param>
        public static void AbrirTienda(Jugador p)
        {
            Console.Clear();
            int pocionPrecio;
            int armaduraPrecio;
            int armaPrecio;
            int difP;
            while (true)
            {
                pocionPrecio = 20 + 10 * p.Mods;
                armaduraPrecio = 100 * (p.Armadura+1);
                armaPrecio = 100 * p.PoderDelArma ;
                difP = 300 + 100 * p.Mods;

                Console.WriteLine("       Tiendia de abarrotes   ");
                Console.WriteLine("*============================*");
                Console.WriteLine(" (R)eforzar arma   $" + armaPrecio +"   |");
                Console.WriteLine(" (A)rmadura        $" + armaduraPrecio + "   |");
                Console.WriteLine(" (P)ociones        $" + pocionPrecio + "    |");
                Console.WriteLine(" (S)alir                      ");
                Console.WriteLine("*============================*");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("   Estadisticas del jugador   ");
                Console.WriteLine("");
                Console.WriteLine("     Dinero del jugador " + p.Monedas);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("*============================*");
                Console.WriteLine("| Salud :              " + p.Vida );
                Console.WriteLine("| Poder del arma :     " + p.PoderDelArma);
                Console.WriteLine("| Valor de armadura :  " + p.Armadura);
                Console.WriteLine("| Pociones :           " + p.Pociones);
                Console.WriteLine("*============================*");
                string input = Console.ReadLine();
                input = input.ToLower();
                if (input == "r" || input == "reforzar") 
                {
                    Comprar("arma", armaPrecio, p);
                }else if (input == "a" || input == "armadura")
                {
                    Comprar("armadura", armaduraPrecio, p);
                }else if (input == "p" || input == "pociones")
                {
                    Comprar("pocion", pocionPrecio, p);
                }else if(input == "s"|| input == "salir")
                {
                    Console.WriteLine("Vuelva pronto!");
                    Console.ReadKey();
                    return;
                }
            }
        }
        /// <summary>
        /// Metodo que intercambia el oro del jugador por un objeto o mejora de la tienda
        /// </summary>
        /// <param name="objeto">Objeto a comprar</param>
        /// <param name="costo">Costo del objeto</param>
        /// <param name="p">Objeto del jugador, para poder realizar la compra si se tiene el oro necesario, tambien para modificar los stats y objetos del jugador si es que se compra</param>
        static void Comprar(string objeto,int costo,Jugador p)
        {
            if(p.Monedas >= costo)
            {
                switch (objeto)
                {
                    case "pocion":
                        p.Pociones++;
                        break;
                    case "armadura":
                        p.Armadura++;
                        break;
                    case "arma":
                        p.PoderDelArma++;
                            break;
                }
                p.Monedas -= costo;
    
            }
            else
            {
                Console.WriteLine("Parece que no tienes dinero suficiente");
                Console.ReadKey();
            }
            Console.Clear();
        }
    }
}
