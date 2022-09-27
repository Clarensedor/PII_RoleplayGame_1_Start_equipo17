using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    public class Humano
    {      
    //Se definen los atributos/propiedades
      private string nombre;
      private int vida;
      private int danio;
      private int defensa;
      private Espada espada;
      private Escudo escudo;

      public  int vidaTotal;

      //se define el constructor
      public Humano(string nombre, int vida, int danio, int defensa, Espada espada, Escudo escudo)
      {
         this.Nombre = nombre;
         this.Vida = vida;
         vidaTotal = vida;
         this.Danio = danio;
         this.Defensa = defensa;
         this.Espada = espada;
         this.Escudo = escudo;
      }

      //definimos getters y setters
      public string Nombre{ get{return this.nombre;}set{this.nombre = value;}}

      public int Vida{get{return this.vida;}set{this.vida = value;}}

      public int Danio{get{return this.danio;}set{this.danio = value;}}
      public int Defensa{get{return this.defensa;}set{this.defensa = value;}}
      public Espada Espada{get{return this.espada;}set{this.espada = value;}}
      public Escudo Escudo{get{return this.escudo;}set{this.escudo = value;}}

      //metodos/comportamientos
      
      //Recibe daño
      public void RecibirDanio(int dañoRecibido)
      {

         this.vida = this.vida - (dañoRecibido - this.defensa);
         if(this.vida < 0){
          this.vida = 0;
         }
      
      }

      //Vuelve a su vida inicial
      public void Curarse()
      {

          this.vida = vidaTotal;

      }

      public void EquiparEspada(){

        this.Danio += this.Espada.Ataque;

      }
      List 
      public void EquiparEscudo(){

        this.Danio += this.Escudo.Defensa;
      }

    }
}