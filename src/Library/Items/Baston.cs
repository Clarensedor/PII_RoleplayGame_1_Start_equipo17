using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Baston
    {
        private int ataque;
        
        public Baston ()
        {
            this.Ataque = 0;
        }

        public int Ataque{get{return this.ataque;}set{this.ataque = value;}}

    }
}        

