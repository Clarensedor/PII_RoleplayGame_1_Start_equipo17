using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    public class Elfo
    {      //Se definen los atributos/propiedades
    
    //Se definen los atributos/propiedades
      private string nombre;
      private int vida;
      private int danio;
      private int defensa;

      public  int vidaTotal;

      //se define el constructor
      public Elfo(string nombre, int vida, int danio, int defesa)
      {
         this.Nombre = nombre;
         this.Vida = vida;
         vidaTotal = vida;
         this.Danio = danio;
         this.Defensa = defensa;
      }

      //definimos getters y setters
      public string Nombre{ get{return this.nombre;}set{this.nombre = value;}}

      public int Vida{get{return this.vida;}set{this.vida = value;}}

      public int Danio{get{return this.danio;}set{this.danio = value;}}
      public int Defensa{get{return this.danio;}set{this.danio = value;}}

      //metodos/comportamientos
      
      //Recibe daño
      public void RecibirDanio(int dañoRecibido)
      {
         this.vida = this.vida - dañoRecibido;
      }

      //Vuelve a su vida inicial
      public void Curarse()
      {
          this.vida = vidaTotal;
      }

/*
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
        */
    }
}
