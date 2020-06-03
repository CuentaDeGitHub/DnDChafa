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

        public int ObtenerVida(Jugador p)
        {
            int superior = (2 * p.mods + 5);
            int inferior = (mods + 2);
            return r.Next(inferior, superior);
        }

        public int ObtenerFuerza(Jugador p)
        {
            int superior = (2 * p.mods + 2);
            int inferior = (p.mods + 1);
            return r.Next(inferior, superior);
        }
        public int ObtenerMonedas(Jugador p)
        {
            int superior = (10 * p.mods + 50);
            int inferior = (10*p.mods + 10);
            return r.Next(inferior, superior);
        }
    }
}
