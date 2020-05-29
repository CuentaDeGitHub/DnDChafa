using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDChafa
{
    public class Tiendita
    {
      
        public static void CargarTienda(Jugador p)
        {
 
            AbrirTienda(p);
        }
        public static void AbrirTienda(Jugador p)
        {
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
                Console.WriteLine(" (E)spada          $" + armaPrecio +"   |");
                Console.WriteLine(" (A)rmadura        $" + armaduraPrecio + "   |");
                Console.WriteLine(" (M)odificador     $" + difP + "   |");
                Console.WriteLine(" (P)ociones        $" + pocionPrecio + "    |");
                Console.WriteLine(" (S)alir            ");
                Console.WriteLine("*============================*");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("   Estadisticas del jugador   ");
                Console.WriteLine("*============================*");
                Console.WriteLine("| Salud :              " + p.Vida );
                Console.WriteLine("| Poder del arma :     " + p.PoderDelArma);
                Console.WriteLine("| Valor de armadura :  " + p.Armadura);
                Console.WriteLine("| Pociones :           " + p.Pociones);
                Console.WriteLine("| Monedas :            " + p.Monedas);
                Console.WriteLine("| Modificadores :      " + p.Mods);
                Console.WriteLine("*============================*");
                string input = Console.ReadLine();
                input = input.ToLower();
                if (input == "e" || input == "espada") 
                {
                    Comprar("arma", armaPrecio, p);
                }else if (input == "a" || input == "armadura")
                {
                    Comprar("armadura", armaduraPrecio, p);
                }else if (input == "p" || input == "pociones")
                {
                    Comprar("pocion", pocionPrecio, p);
                }else if (input == "m" || input == "modificador")
                {
                    Comprar("modificador", difP, p);
                }else if(input == "s"|| input == "salir")
                {
                    return;
                }
                    
                
            }
            
        }
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
                    case "modificador":
                        p.Mods++;
                            break;
                }
                p.Monedas -= costo;
    
            }
            else
            {
                Console.WriteLine("Otra vez sin lana");
                Console.ReadKey();
                
            }
            Console.Clear();
        }
    }
}
