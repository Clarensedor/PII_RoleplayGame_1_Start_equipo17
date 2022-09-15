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

      private int items;

      public  int vidaTotal;

      //se define el constructor
      public Enano(int id, string nombre, int vida, int danio)
      {
         this.Nombre = nombre;
         this.Vida = vida;
         vidaTotal = vida;
         this.Danio = danio;
      }

      //definimos getters y setters
      public string Nombre{ get{return this.nombre;}set{this.nombre = value;}}

      public int Vida{get{return this.vida;}set{this.vida = value;}}

      public int Danio{get{return this.danio;}set{this.danio = value;}}


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