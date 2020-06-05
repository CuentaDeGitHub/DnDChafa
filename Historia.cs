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
            int speed = 15;
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }
        public static string PregunarNombre()
        {
            Console.Clear();
            Imprimir("Bienvenido al fin del mundo");
            Console.WriteLine("Nombre del personaje:");
            string n = Console.ReadLine();
            return n;
        }
        public static void HistoriaPrincipio(string n)
        {
            Console.Clear();
            Imprimir("Despiertas en una cueva, es un paisaje muy familiar.");
            Imprimir("Has vivido aqui encerrado y temeroso del mundo exterior por la mayor parte de tu vida.");
            Imprimir("Año tras año con el mismo paisaje han distorsionado tu mente, tus memorias se vuelven borrosas.");

            if (n == "")
            {
                Imprimir("No recuerdas ni tu propio nombre");
            }
            else
            {
                Imprimir("Lo unico que te pertenece es tu propio nombre... " + n);
            }
            Console.ReadKey();
            Console.Clear();
            Imprimir("Tienes una memoria clara, mezclada entre todos los dias identicos que has pasado en aislamiento en este lugar");
            Imprimir("Una luz clara en el cielo, despues de eso todo la vida de la zona murio y con ello la civilizacion");
            Imprimir("Ese evento provoco un colapso de la sociedad y de las morales de los pocos sobrevivientes");
            Imprimir("Deseando alejarte del caos, decidiste recluirte en esta cueva, asi evitando el mundo exterior");
            Imprimir("Ha pasado mucho tiempo, existen rumores de una sociedad establecida");
            Imprimir("Tus recursos se han extinguido casi por completo, sabias que este dia llegaria eventualmente");
            Imprimir("Tomas lo ultimo que te queda de comida, tu valentia, y una roca afilada");
            Imprimir("Es hora de afrontar el fin del mundo y encontrar la civilizacion denuevo");
            Console.ReadKey();
        }
        public static void HistoriaDesarrollo()
        {
            Console.Clear();
            Imprimir("Despues de muchas adversidades logras llegar a la tierra prometida.");
            Imprimir("Te encuentras enfrente de las puertas de la civilizacion, pero eres detenido por el disparo de un arma.");
            Imprimir("!Detente ahi!- Exclama una voz que te llama desde arriba de las puertas.");
            Imprimir("Entiendo tu situacion, pero este lugar esta lleno por el momento.");
            Imprimir("Pero soy generoso, probablemente tengamos un lugar disponible para ti en algunos dias.");
            Imprimir("Vuelve en unos cuantos dias, no creo que sea mucho pedir que sobrevivas un poco mas de tiempo ahi afuera.");
            Imprimir("Incluso te dare un regalo, para que veas que soy buena persona.");
            Console.WriteLine("Has obtenido 10 Pociones!");
            Console.ReadKey();
        }
        public static void HistoriaFinal()
        {
            Console.Clear();
            Imprimir("Han pasado algunos dias, y te dispones a volver a ese lugar, donde te habian prometido un lugar.");
            Imprimir("Al llegar a la zona, eres bienvenido por la misma voz de la vez anterior.");
            Imprimir("Lo ves? Sabia que no tendrias problema aguantando algunos dias mas alla afuera.");
            Imprimir("Y yo he mantenido mi palabra.............. tecnicamente.");
            Imprimir("Veras, si hay un lugar disponible..... solo uno.");
            Imprimir("Y le hice una promesa similar a ese hombre de ahi.");
            Imprimir("Dirigues tu mirada a donde apunta el hombre, y ahi es donde lo ves.");
            Imprimir("Un hombre en las mismas o incluso peores condiciones que tu, se ve que ha pasado por mucho.");
            Imprimir("No pense que tuvieramos solo un espacio disponible.");
            Imprimir("Asi que porque no resuelven este problema entre ustedes dos?");
            Imprimir("Esta es tu unica oportunidad de tener un lugar seguro, no puedes dejarlo ir.");
            Console.ReadKey();

        }
        ~Historia()
        {
            Console.WriteLine("La instancia de historia se ha destruido");
            Console.ReadKey();
        }
    }
}
