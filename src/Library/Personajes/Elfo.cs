using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    public class Elfo
    {      //Se definen los atributos/propiedades
      public string nombre;
      private int vida;
      private int danio;
      private int defensa;

      private int items;

      public  int vidaTotal;

        public string Nombre { get => nombre; set => nombre = value; }   

        public int Vida{get{return this.Vida;}set{this.Vida = value;}}

        public int Danio{get{return this.danio;}set{this.danio = value;}}

        //se define el constructor
        public Elfo(int id, string nombre, int vida, int danio)
      {
         this.Nombre = nombre;
         this.Vida = vida;
         vidaTotal = vida;
         this.Danio = danio;
      }

        //PLANTEO LOS METODOS PARA EVALUAR ENTRE TODOS EN CLASE

        public int RecibirDaño ()
        {
            return 1;
        }
        
        public int Curarse ()
        {
            return 1;
        }
        
        public int ObtenerDefensa ()
        {
            return 1;
        }
        
        public int ObtenerAtaque ()
        {
            return 1;
        }
        
        public int EquiparItem ()
        {
            return 1;
        }
    }
}
