using System;
using System.Collections.Generic;
namespace Program
{
    public class Troll
    {
        public string nombreTrl {get; set;}
        public int vida {get; set;}
        public int daño {get; set;}
        public int defensa {get; set;}
        public int ataque {get; set;}
        

        public Troll(string nombre, int vida, int daño, int defensa)
        {
            this.nombreTrl = nombre;
            this.vida = vida;
            this.daño = daño;
            this.defensa = defensa;
        }

        public int RecibirDaño(int daño)
        {
            vida-=daño;
            return vida; 
        }

        public int Curarse(int poción)
        {
            vida+=poción;
            return vida;
        }

        public int ObtenerDefensa(int defensa)
        {
            this.defensa=defensa;
            return 1;
        }
        
        public int ObtenerAtaque(int ataque)
        {
            this.ataque=ataque;
            return 1;
        }

        
    }
}

