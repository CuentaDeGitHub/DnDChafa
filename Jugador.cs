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
        public Jugador (string nombre,int vida,int monedas, int armadura, int pociones,int poderDelArma,int experiencia):base()
        {
            Nombre = nombre;
            Vida = vida;
            Monedas = monedas;
            Armadura = armadura;
            Pociones = pociones;
            PoderDelArma = poderDelArma;
            Exp = experiencia;
        }

        public override int Atacar()
        {
            return 0;
        }
        public int ObtenerVida(Jugador p)
        {
            int superior = (2 * (p.Exp/2) + 1);
            int inferior = (p.Exp + 1);
            return r.Next(inferior, superior);
        }

        public int ObtenerFuerza(Jugador p)
        {
            int superior = (2 * p.Exp + 1);
            int inferior = (p.Exp + 1);
            return r.Next(inferior, superior);
        }
        public int ObtenerMonedas(Jugador p)
        {
            int superior = (7 * p.Exp + 40);
            int inferior = (3*p.Exp + 10);
            return r.Next(inferior, superior);
        }
    }
}
