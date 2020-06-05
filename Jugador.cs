using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDChafa
{
    public class Jugador : Personaje
    {
        Random r = new Random();

        private int experiencia;
        public int Exp
        {
            get { return experiencia; }
            set { experiencia = value; }
        }

        private int monedas;
        public int Monedas
        {
            get { return monedas; }
            set { monedas = value; }
        }
        private int pociones;
        public int Pociones
        {
            get { return pociones; }
            set { pociones = value; }
        }
        private int mods;
        public int Mods
        {
            get { return mods; }
            set { mods = value; }
        }
        public Jugador (string nombre,int vida,int monedas, int armadura, int pociones,int poderDelArma,int mods,int experiencia):base()
        {
            Nombre = nombre;
            Vida = vida;
            Monedas = monedas;
            Armadura = armadura;
            Pociones = pociones;
            PoderDelArma = poderDelArma;
            Mods = mods;
            Exp = experiencia;
        }

        public  int Atacar()
        {
            return (r.Next(0, PoderDelArma + 1) + r.Next(1, 4));
        }
        public override void Victoria()
        {
            Console.WriteLine("Easy peasy");
        }
       
        public int ObtenerVida(Jugador p)
        {
            int superior = (2 * p.Mods + 5);
            int inferior = (p.Mods + 3);
            return r.Next(inferior, superior);
        }

        public int ObtenerFuerza(Jugador p)
        {
            int superior = (2 * p.Mods + 3);
            int inferior = (p.Mods + 1);
            return r.Next(inferior, superior);
        }
        public int ObtenerMonedas(Jugador p)
        {
            int superior = (5 * p.Mods + 50);
            int inferior = (3 * p.Mods + 25) ;
            return r.Next(inferior, superior);
        }
    }
}
