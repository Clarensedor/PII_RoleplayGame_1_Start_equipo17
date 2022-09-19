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
        private string nombre;
        
        public Baston (int ataque, string nombre)
        {
            this.Ataque = ataque;
            this.Nombre = nombre;
        }

        public int Ataque{get{return this.ataque;}set{this.ataque = value;}}
        public string Nombre{get{return this.nombre;}set{this.nombre = value;}}

    }
}        

