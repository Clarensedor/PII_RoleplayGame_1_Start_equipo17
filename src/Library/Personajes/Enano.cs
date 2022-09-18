using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
   //Se declara la clase
   public class Enano{

      //Se definen los atributos/propiedades
      private string nombre;
      private int vida;
      private int danio;
      private int defensa;

      public  int vidaTotal;

      //se define el constructor
      public Enano(string nombre, int vida, int danio, int defesa)
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
      public void RecibirDanio(int dañoRecibido)
      {
      }

      public void Curarse(int dañoRecibido)
      {
          
      }
      public void ObtenerDefensa(int dañoRecibido)
      {
      }
      public void ObtenerAtaque(int dañoRecibido)
      {
      }

      public void EquiparItem(int dañoRecibido)
      {
      }

    }
}