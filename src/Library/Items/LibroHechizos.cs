using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class LibroHechizos
    {
        public List<Hechizo> hechizos;
        private int ataque;
        
        public LibroHechizos ()
        {
            this.hechizos = new List<Hechizo>();
            this.Ataque = 0;
        }

        public int Ataque{get{return this.ataque;}set{this.ataque = value;}}

        public void AgregarHechizo(Hechizo hechizo)
        {

            this.hechizos.Add(hechizo);

        }

    }
}