namespace Program
{
   //Se declara la clase
   public class Pony {

      //Se definen los atributos/propiedades
      private string nombre;
      private int ataque;
      private int defensa;

      //constructor
      public Pony(string nombre, int ataque){
         this.Nombre = nombre;
         this.Ataque = ataque;
      }

      //getters and seters
      public string Nombre { get; private set; }
      public int Ataque { get; private set; }

   }


}