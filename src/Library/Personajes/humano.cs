using System;
using System.Collections.Generic;

namespace gameLoop
{

    public class Humano {

        string name{get; set}
        int health{get; set}
        int damage{get; set}
        int defense{get; set}
        List<Item> items;
        Item rightHand;
        Item leftHand;


        public Humano(string nam, int healt, int damag, int defens){

            this.name = nam;
            this.health = healt;
            this.damage = damag;
            this.items = new List<Item>();
            this.rightHand = null;
            this.leftHand = null;


        }

        //Aplica daño recibido
        public void ApplyDamage(int daño, string tipo){

            damageTaken = daño;
            damageTaken = damageTaken - defense;
            if(damageTaken < 0){

                return;
                
            }
            else{            


                this.health = this.health - damageTaken;
                return;            
            
            }


        }

        //Aplica curaciones
        public void Heal(int curacion){

            this.health = this.health + curacion;
            
        }

        //Agrega un item al inventario
        public void PickItem(Item item){

            this.items.Add(item);

        }

        //Equipa items del inventario
        public void EquipItem(string itemName){

            for(i = 0; i <= this.items.GetRange(); i++){

                if(items[i].name == itemName){

                    if(items[i].type == "Weapon"){

                        rightHand = items[i];
                        this.damage = this.damage +  this.items[i].attack;                        
                        
                    }
                    else if(items[i].type == "Shield"){

                        leftHand = items[i];
                        this.defense = this.defense + this.items[i].defense;
                        
                    }                    
                    else if(items[i].type == "potion"){

                        this.health == this.health + this.items[i].defense;
                        this.items.RemoveAt(i);
                        
                    }
                }
            }
        }
    }
}