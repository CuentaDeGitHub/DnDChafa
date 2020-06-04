using System;
using System.IO;

namespace DnDChafa
{
    class Historia
    {
        public static void Guardar(string Ruta,string Datos)
        {
            if (File.Exists(Ruta))
            {
                File.Delete(Ruta);
            }
            using (StreamWriter sw = File.CreateText(Ruta))
            {
                sw.WriteLine(Datos);
            }
        }
        public static void Imprimir(string text)
        {
            int speed = 40;
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }
        public static void HistoriaPrincipio(Jugador p)
        {
            Console.Clear();
            Imprimir("Bienvenido al fin del mundo");
            Console.WriteLine("Nombre del personaje:");
            p.Nombre = Console.ReadLine();
            Console.Clear();
            Imprimir("Despiertas en una cueva, es un paisaje muy familiar");
            Imprimir("Has vivido aqui encerrado y temeroso del mundo exterior por la mayor parte de tu vida.");
            Imprimir("Año tras año con el mismo paisaje han dañado tu mente tus memorias se vuelven borrosas");

            if (p.Nombre == "")
            {
                Imprimir("No recuerdas ni tu propio nombre");
            }
            else
            {
                Imprimir("Lo unico que te pertenece es tu propio nombre... " + p.Nombre);
            }
            Console.ReadKey();
            Console.Clear();
            Imprimir("Tienes una memoria clara, mezclada entre todos los dias identicos que has pasado en aislamiento en este lugar");
            Imprimir("Una luz clara en el cielo, despues de eso todo la vida de la zona murio y con ello la civilizacion");
            Imprimir("Ese evento provoco un colapso de la civilizacion y las morales de los pocos sobrevivientes");
            Imprimir("Deseando alejarte del caos, decidiste recluirte en esta cueva, asi evitando el mundo exterior");
            Imprimir("Ha pasado mucho tiempo, tal vez el mundo exterior ha cambiado..");
            Imprimir("Tus recursos se han extinguido casi por completo, sabias que este dia llegaria eventualmente");
            Imprimir("Tomas lo ultimo que te queda de comida, tu valentia, y una roca afilada");
            Imprimir("Es hora de afrontar el fin del mundo");
            Console.ReadKey();
        }
    }
}
