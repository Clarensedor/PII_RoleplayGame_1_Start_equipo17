using System;
using System.Collections.Generic;

namespace Program
{

    public class Humano {

        public string name{get; set}
        private int health{get; set}
        public int damage{get; set}
        public int defense{get; set}
        private List<Item> items;
        private Item rightHand; // que es Item?
        private Item leftHand;

        //Constructor clase Humano
        public Humano(string nam, int healt, int damag, int defens){ // Tendriamos que poner todo esto en comun, sino es medio confuso

            this.name = nam;
            this.health = healt;
            this.damage = damag;
            this.defense = defens;
            this.items = new List<Item>();
            this.rightHand = null; // Por que aca pusiste null?
            this.leftHand = null;
        }

<<<<<<< Updated upstream
        //Ataca un enemigo
        public void Attack(Enemigo enemy){ // no habiamos quedado en que no habia un metodo que era atacar, sino solo recibir daño?
=======
       /* //Ataca un enemigo
        public void Attack(Enemigo enemy){
>>>>>>> Stashed changes

            enemy.ApplyDamage(this.attack);
            if(enemy.health == 0){
                PickItem(enemy.DropLoot());
            }
        }*/

        //Aplica daño recibido
        public void ApplyDamage(int daño){

            int damageTaken = daño - this.defense;
            
            if(damageTaken > 0){

                this.health -= damageTaken;
                
            }
        }

        //Aplica curaciones
        public void Heal(int curacion){

            this.health += curacion;
            
        }

        //Agrega un item al inventario
        public void PickItem(Item item){

            this.items.Add(item);

        }

        //Equipa items del inventario
        public void EquipItem(string itemName){

            for(int i = 0; i <= this.items.GetRange(); i++){

                if(items[i].name == itemName){

                    if(items[i].type == "Weapon"){

                        UnequipItem(this.rightHand.name)
                        this.rightHand = items[i];
                        this.damage += this.items[i].attack;
                        this.defense += this.items[i].defense;                        
                        
                    }
                    else if(items[i].type == "Shield"){

                        UnequipItem(this.leftHand.name)
                        this.leftHand = items[i];
                        this.defense += this.items[i].defense;
                        
                    }                    
                    else if(items[i].type == "Potion"){

                        this.health = this.Heal(this.items[i].defense);
                        this.items.RemoveAt(i);
                        
                    }
                }
            }
        }

        //Desequipa items de las manos
        public void UnequipItem(string itemName){

            if(this.rightHand.name == itemName){
                
                this.rightHand = null;

            } else if(this.leftHand.name == itemName){

                this.leftHand = null;
                
            }
        }      
    }
}
