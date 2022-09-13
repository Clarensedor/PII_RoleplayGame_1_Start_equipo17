using System;

namespace gameLoop
{

    public class Humano {

        string name{get; set}
        int health{get; set}
        int damage{get; set}
        int defense{get; set}
        List<Items> items;

        public Humano(string nam, int healt, int damag, int defens){

            this.name = nam;
            this.health = healt;
            this.damage = damag;
            this.items = new List<Items>();
            
              
        }

    }
    
}