﻿using System;
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
            Elfo legolas = new Elfo (1,"Legolas", 100, 100, arquito1,null );
            legolas.EquiparArco();
            Console.WriteLine (legolas.Danio);
            Console.WriteLine (legolas.Arco.nombre);
            enanoVirgo.RecibirDanio(legolas.danio);
            Console.WriteLine (enanoVirgo.vida);

    }
}
}
