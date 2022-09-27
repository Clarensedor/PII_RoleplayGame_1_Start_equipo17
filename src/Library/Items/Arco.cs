using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Program
{
    public class Arco
    {
        string nombre;
        int ataque ;
        int defensa;
        List

        public string Nombre { get => nombre; set => nombre = value; }
        public int Ataque { get => ataque; set => ataque = value; }
        public int Defensa { get => defensa; set => defensa = value; }
              //se define el constructor
      public Arco (string nombre, int ataque, int defesa)
      {
         this.Nombre = nombre;
         this.Ataque = ataque;
         this.Defensa = defensa;
      }
    }
}