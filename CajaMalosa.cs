using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDChafa
{
    class CajaMalosa : ICajita
    {
        public void AbrirCaja(Jugador p)
        {
            Console.Clear();
            Console.WriteLine("Al abrir la caja puedes sentir como una oscuridad oscurece tu vista.");
            Console.WriteLine("Te sientes desorientado, mareado.");
            Console.WriteLine("La oscuridad se dispersa, pero puedes sentir que algo cambio");
            Console.WriteLine();
            Console.WriteLine("Sientes como si las cosas se hubieran vuelto mas dificiles");
            p.Mods++;
           
        }
        public void MantenerCajaCerrada(Jugador p)
        {
            Console.WriteLine("Optas por no tocar la caja y dejarla justo donde la encontraste");
            Console.WriteLine("Sientes como si hubieras hecho lo correcto");
            Console.WriteLine("Te sientes bien al respecto");
            p.Vida += 5;
            p.Exp++;
        }
    }
}
