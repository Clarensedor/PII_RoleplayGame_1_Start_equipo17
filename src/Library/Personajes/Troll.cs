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

        public int recibirDaño(int daño)
        {
            vida-=daño;
            return vida; 
        }

        public int curarse(int poción)
        {
            vida+=poción;
            return vida;
        }

        public int obtenerDefensa(int defensa)
        {
            this.defensa=defensa;
        }
        
        public int obtenerAtaque(int ataque)
        {
            this.ataque=ataque;
        }

        
    }
}

