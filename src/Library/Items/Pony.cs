using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
   //Se declara la clase
   public class Pony {

      //Se definen los atributos/propiedades
      private string nombre;
      private int ataque;
      private int defensa;

      private static List<int> charactersId = new List<int>();

      //constructor
      public Pony(string nombre, int ataque, int defensa){
         this.Nombre = nombre;
         this.Ataque = ataque;
         this.Defensa = defensa; 
      }

      //getters and seters
      public string Nombre { get; private set; }

      public int Ataque { get; private set; }
      public int Defensa { get; private set; }
      public void CharactersId(int identificador)
      {
            charactersId.Add(identificador);
      }
      
   }


}