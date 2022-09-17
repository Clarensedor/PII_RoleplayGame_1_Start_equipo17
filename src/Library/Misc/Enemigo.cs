  using System;

namespace program {

    public class Enemigo {

        public string name {get ; set}
        public int health {get ; set}
        public int attack {get ; set}
        private int defense {get ; set}


        public Enemigo(string name, int attack, int defense){

            this.name = name;
            this.attack = attack;
            this.defense = defense;
        }

        //Aplica daño recibido
        public void ApplyDamage(int daño){

            int damageTaken = daño - this.defense;
            
            if(damageTaken > 0){

                this.health -= damageTaken;
                
            }
        }

        //Dropea Loot
        public void DropLoot(){

            return item;
        }        
    }
}