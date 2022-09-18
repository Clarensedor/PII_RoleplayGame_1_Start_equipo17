using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace program{

    public class Escudo{

        public string name {get; set;}
        public int damage {get; set;}
        public int defense {get; set;}

        private static List<int> charactersId = new List<int>();

        public Escudo(string name, int damage, int defense){

            this.name = name;
            this.damage = damage;
            this.defense = defense;
        }
    }
}