using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DnDChafa
{
    class Program
    {
        public static Jugador JugadorActual;
        public static bool loopPrincipal = true;
        public static int PartidaNueva;
        public static string NombreDePartida = @"C:\Users\Wande\Desktop\Partida.txt";


        static void Main(string[] args)
        {
             MenuPrincipal();

            if (JugadorActual.Exp == 0){
                JugadorActual.Nombre = Historia.PregunarNombre();
                Historia.HistoriaPrincipio(JugadorActual.Nombre);
                Encuentros.PrimerEncuentro(JugadorActual);
            }
            Loop(loopPrincipal);
            
        }
        /// <summary>
        /// Loop donde al usuario se le da 4 opciones diferentes de que quiere hacer
        /// Hacer un encuentro aleatorio
        /// Visitar la tienda
        /// Guardar su partida
        /// Salir del programa
        /// </summary>
        /// <param name="LoopPrincipal">Mientras el bool sea verdadero se le seguiran presentando las 4 opciones al jugador</param>
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
                    if(JugadorActual.Exp == 8)
                    {
                        Historia.HistoriaDesarrollo();
                        JugadorActual.Mods++;
                        JugadorActual.Pociones += 5;
                        JugadorActual.Exp++;
                    }else if(JugadorActual.Exp == 14)
                    {
                        //Historia.HistoriaFinal();
                        Enemigo EnemigoFinal = new Enemigo();
                        Combate.Pelea(false, EnemigoFinal.Nombre, EnemigoFinal.PoderDelArma, EnemigoFinal.Vida, JugadorActual);
                        Console.Clear();
                        if(JugadorActual.Exp == 14)
                        {
                            Console.WriteLine("Mientras el hombre te golpea, puedes escuchar como dice");
                            EnemigoFinal.Victoria();
                            Console.WriteLine();
                            Console.WriteLine("No pudiste vencerlo...");
                            Console.WriteLine("En tu desesperacion, hiciste lo que mejor sabes hacer.");
                            Console.WriteLine("Huir y esconderte como un cobarde.");
                            Console.WriteLine("Este es el fin.....");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else
                        {
                            Historia.Imprimir("Lo has logrado,tu adversario ha muerto.");
                            Historia.Imprimir("Has conseguido un lugar en esta civilizacion.");
                            Historia.Imprimir("Civilizacion y paz....");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        
                    }
                    else
                    {
                        Encuentros.EncuentroAleatorio(JugadorActual);
                    }
                    
                }else if (input == "t" || input == "tienda")
                {
                    Tiendita.AbrirTienda(JugadorActual);
                }else if(input == "g" || input == "guardar")
                {
                    //Nombre,Vida,Monedas,Armadura,Pociones,PoderDelArma,Mods,Exp
                    string Datos = (JugadorActual.Nombre + "," + JugadorActual.Vida + "," + JugadorActual.Monedas + "," + JugadorActual.Armadura + "," + JugadorActual.Pociones + "," + JugadorActual.PoderDelArma + "," + JugadorActual.Mods + "," +JugadorActual.Exp);
                    Historia.Guardar(NombreDePartida, Datos);
                    Console.WriteLine("Los datos han sido guardados");
                    
                    Console.ReadKey();
                }else if(input == "s"|| input == "salir")
                {
                    Console.WriteLine("Hasta luego!");
                    Environment.Exit(0);

                }



            }
        }
        /// <summary>
        /// Da la opcion al jugador de iniciar una partida nueva, con un personaje nuevo 
        /// o empezar una partida con un personaje guardado en una partida previa
        /// Se necesita un documento de texto llamado Partida.txt para cargar un personaje
        /// </summary>
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
                    //Nuevo personaje
                    JugadorActual = new Jugador("", 10, 100, 0, 5, 1,0,0);

                    break;
                case 1:
                    //Cargar personaje
                    String Linea = File.ReadAllText(NombreDePartida);
                    String[] Datos = Linea.Split(',');
                    JugadorActual = new Jugador(Datos[0], int.Parse(Datos[1]), int.Parse(Datos[2]), int.Parse(Datos[3]), int.Parse(Datos[4]), int.Parse(Datos[5]), int.Parse(Datos[6]),int.Parse(Datos[7]));
                    break;
                case 2:
                    MenuPrincipal();
                    break;
            }

        }    
    }
}
