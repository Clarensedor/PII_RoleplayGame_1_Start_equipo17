using System;

namespace program{

    public class Espada{

        public string name {get; set}
        public int damage {get; set}
        public int defense {get; set}

        public Espada(string name, int damage, int defense){

            this.name = name;
            this.damage = damage;
            this.defense = defense;
        }
    }
}