using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDChafa
{
    class CajaBuena : ICajita
    {
        public void AbrirCaja(Jugador p)
        {
            Console.Clear();
            Console.WriteLine("Al abrir la caja puedes ver como emana una luz resplandecente");
            Console.WriteLine("La luz que la caja emite es calida");
            Console.WriteLine("Puedes sentir como la energia corre por tu cuerpo");
            Console.WriteLine();
            Console.WriteLine("Te sientes un poco mas resistente!");
            p.Vida += 10;
            p.Armadura++;
        }
        public void MantenerCajaCerrada(Jugador p)
        {
            Console.WriteLine("Optas por no tocar la caja y dejarla justo donde la encontraste");
            Console.WriteLine("Sientes como si hubieras hecho algo malo");
            p.Mods++;
        }
    }
}
