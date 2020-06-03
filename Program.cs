using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDChafa
{
    class Program
    {
        public static Jugador JugadorActual;
        public static bool loopPrincipal = true;
        public static int PartidaNueva;
        public static Historia Historiador;
        static void Main(string[] args)
        {
             MenuPrincipal();
            Console.WriteLine(JugadorActual.Pociones);
            Console.ReadKey();
            Loop(loopPrincipal);
            
        }
        static void Loop(bool LoopPrincipal)
        {
            while (loopPrincipal)
            {
                Console.Clear();
                Console.WriteLine("*==========================*");
                Console.WriteLine("| (E)xplorar    (T)ienda   |");
                Console.WriteLine("| (G)uardar     (S)alir    |");
                Console.WriteLine("*==========================*");
                string input = Console.ReadLine();
                input = input.ToLower();
                if (input == "e" || input == "explorar")
                {
                    Encuentros.EncuentroAleatorio(JugadorActual);
                }else if (input == "t" || input == "tienda")
                {
                    Tiendita.AbrirTienda(JugadorActual);
                }else if(input == "g" || input == "guardar")
                {
                    Console.WriteLine("Los datos han sido guardados");
                }else if(input == "s"|| input == "salir")
                {
                    Console.WriteLine("Hasta luego!");
                    Environment.Exit(0);

                }



            }
        }
        static void MenuPrincipal()
        {
            
            Console.Clear();
            Console.WriteLine("Bienvenido!");
            Console.WriteLine();
            Console.WriteLine("*====================================*");
            Console.WriteLine("|                                    |");
            Console.WriteLine("| (N)ueva partida   (C)argar partida |");
            Console.WriteLine("|                                    |");
            Console.WriteLine("*====================================*");
            string input = Console.ReadLine();
            input = input.ToLower();
            if (input == "n" || input == "nueva partida")
            {
                PartidaNueva = 0;
            }
            else if (input == "c" || input == "cargar partida")
            {
                Console.Clear();
                Console.WriteLine("Para continuar con una partida, requieres un documento de texto en tu escritorio llamado -Partida.txt");
                Console.WriteLine("Si usted tiene tal documento presio Y para continuar");
                Console.WriteLine("De lo contrario presione cualquier tecla para volver");
                string inputCargar = Console.ReadLine();
                if (inputCargar == "Y" || inputCargar == "y")
                {
                    //Leer archivo
                    //Iniciar Loop principal
                    PartidaNueva = 1;
                }
                else
                {
                    PartidaNueva = 2;

                }
            }
            switch (PartidaNueva)
            {
                case 0:
                    JugadorActual = new Jugador("", 10, 100, 0, 5, 1, 0);

                    break;
                case 1:
                    JugadorActual = new Jugador("", 10, 500, 0, 25, 1, 0);
                    break;
                case 2:
                    MenuPrincipal();
                    break;
            }

        }    
    }
}
