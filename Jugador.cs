using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDChafa
{
    public class Jugador
    {
        Random r = new Random();
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int monedas;
        public int Monedas
        {
            get { return monedas; }
            set { monedas = value; }
        }
        private int vida;
        public int Vida
        {
            get { return vida; }
            set { vida = value; }
        }

        private int daño;
        public int Daño
        {
            get { return daño; }
            set { daño = value; }

        }
        private int armadura;
        public int Armadura
        {
            get { return armadura; }
            set { armadura = value; }
        }

        private int pociones;
        public int Pociones
        {
            get { return pociones; }
            set { pociones = value; }
        }

        private int poderDelArma;
        public int PoderDelArma
        {
            get { return poderDelArma; }
            set { poderDelArma = value; }
        }
        public int destreza;
        public int inteligencia;

        private int mods;
        public int Mods
        {
            get { return mods; }
            set { mods = value; }
        }
        public Jugador (string nombre,int vida,int monedas, int armadura, int pociones,int poderDelArma,int mods)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.monedas = monedas;
            this.armadura = armadura;
            this.pociones = pociones;
            this.poderDelArma = poderDelArma;
            this.mods = mods;
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
