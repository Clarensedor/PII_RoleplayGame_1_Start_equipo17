using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    public class Mago
    {      
    //Se definen los atributos/propiedades
      private string nombre;
      private int vida;
      private int danio;
      private int defensa;
      private Baston baston;
      private LibroHechizos libro;

      public  int vidaTotal;

      //se define el constructor
      public Mago(string nombre, int vida, int danio, int defensa, Baston baston, LibroHechizos libro)
      {
         this.Nombre = nombre;
         this.Vida = vida;
         vidaTotal = vida;
         this.Danio = danio;
         this.Defensa = defensa;
         this.Baston = baston;
         this.LibroHechizos = libro;
      }

      //definimos getters y setters
      public string Nombre{ get{return this.nombre;}set{this.nombre = value;}}

      public int Vida{get{return this.vida;}set{this.vida = value;}}

      public int Danio{get{return this.danio;}set{this.danio = value;}}
      public int Defensa{get{return this.defensa;}set{this.defensa = value;}}
      public Baston Baston{get{return this.baston;}set{this.baston = value;}}
      public LibroHechizos LibroHechizos{get{return this.libro;}set{this.libro = value;}}

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

      public void EquiparBaston(){

        this.Danio += this.Baston.Ataque;

      }
      
      public void EquiparLibro(){

        this.Danio += this.LibroHechizos.Ataque;
      }

    }
}
