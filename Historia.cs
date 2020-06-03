using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDChafa
{
    class Historia
    {
        static void HistoriaPrincipio(Jugador p)
        {
            Console.WriteLine("Bienvenido al fin del mundo");
            Console.WriteLine("Nombre del personaje:");
            p.Nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Despiertas en una cueva, es un paisaje muy familiar");
            Console.WriteLine("Has vivido aqui encerrado y temeroso del mundo exterior por la mayor parte de tu vida.");
            Console.WriteLine("Año tras año con el mismo paisaje y comiendo lo unico que encuentras en las zonas cercanas, tus memorias se empiezan a distorsionar");

            if (p.Nombre == "")
            {
                Console.WriteLine("No recuerdas ni tu propio nombre");
            }
            else
            {
                Console.WriteLine("Lo unico que te pertenece es tu propio nombre... " + p.Nombre);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Tienes una memoria clara, mezclada entre todos los dias identicos que has pasado en aislamiento en este lugar");
            Console.WriteLine();
            Console.WriteLine("Una luz clara en el cielo, despues de eso todo la vida de la zona murio y con ello la civilizacion");
            Console.WriteLine();
            Console.WriteLine("Un evento de tal magnitud provoco un colapso de la civilizacion entre los pocos sobrevivientes, haciendo que estos recurrieran a sus instintos mas basicos de supervivencia ");
            Console.WriteLine();
            Console.WriteLine("Deseando alejarte del caos, decidiste recluirte en esta cueva, asi evitando el mundo exterior que ya colapsado ");
            Console.WriteLine();
            Console.WriteLine("Tus recursos se han extinguido casi por completo, sabias que este dia llegaria eventualmente");
            Console.WriteLine("Tomas lo ultimo que te queda de comida, tu valentia, y una roca afilada");
            Console.WriteLine();
            Console.WriteLine("Es hora de afrontar el fin del mundo");
            Console.ReadKey();
        }
    }
}
