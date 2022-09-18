using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Enano enanoVirgo1  = new Enano("Tony", 100 , 20, 10); 
            Pony pony1 = new Pony("Facu", 10, 10);
            Arco arquito1 = new Arco("Arco viejo", 32, 0);
            Flechas flechita = new Flechas ("flechita",5,0);
            Elfo legolas = new Elfo ("Legolas", 100, 100,100, arquito1,flechita );
            legolas.EquiparArco();
            Console.WriteLine (legolas.Danio);
            enanoVirgo1.RecibirDanio(legolas.Danio);
            Console.WriteLine (enanoVirgo1.Vida);
            Console.WriteLine (enanoVirgo1.Defensa);


        }
    }
}
