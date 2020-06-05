using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDChafa
{
    class Enemigo : Personaje

    {
        Random r = new Random();
        public Enemigo() : base()
        {
            Nombre = "El hombre desesperado";
            Vida = 40;
            Armadura = 0;
            PoderDelArma = 4;
        }
        public override void Victoria()
        {
            Console.WriteLine("Perdoname, pero creo que tu entiendes mi situacion");
        }
    }
}
