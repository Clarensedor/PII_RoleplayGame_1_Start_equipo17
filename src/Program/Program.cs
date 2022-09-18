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
            Elfo legolas = new Elfo ("legolas", 100, 10, 10);
            Console.WriteLine(legolas.Nombre);
            Console.WriteLine("el elfo " + legolas.Nombre + " ataca a el enano" + enanoVirgo1.Nombre);
            enanoVirgo1.RecibirDanio(legolas.Danio);
            Console.WriteLine("la vida de " +enanoVirgo1.Nombre+ " quedo en un total de: " + enanoVirgo1.Vida);
            Console.WriteLine(legolas.Defensa);
            Console.WriteLine("el enano se caga y se toma una pocion ");
            enanoVirgo1.Curarse();
            Console.WriteLine("la vida de " +enanoVirgo1.Nombre+ " quedo en un total de: " + enanoVirgo1.Vida);
        

        }
    }
}
