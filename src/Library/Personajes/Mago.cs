using System;
using System.Collections.Generic;

namespace Program
{

    public class Mago {

        public string name{get; set;}
        private int health{get; set;}
        public int damage{get; set;}
        public int defense{get; set;}
        public Baston baston{get;set;}

        //Constructor Mago
        public Mago(string nombre, int vida, int danio, int defensa){ 

            this.name = nombre;
            this.health = vida;
            this.damage = danio;
            this.defense = defensa;
            this.baston = null;
            
        }

        //Aplica daño recibido
        public void ApplyDamage(int daño){

            int damageTaken = daño - this.defense;
            
            if(damageTaken > 0){

                this.health -= damageTaken;
                
            }
        }
     
        public void RecibirDanio(int dañoRecibido)
        {
        }

        public void Curarse(int dañoRecibido)
        {
        }
        public void ObtenerDefensa(int dañoRecibido)
        {
        }
        public void ObtenerAtaque(int dañoRecibido)
        {
        }

        public void EquiparItem(int dañoRecibido)
        {
        }

    }
}
