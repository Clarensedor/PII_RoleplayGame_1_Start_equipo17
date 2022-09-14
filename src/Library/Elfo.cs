using System;

namespace Program
{
    class Elfo
    {
        public string name;
        private int vida = 100;
        public int daño = 100;

        private int defensa = 100;

        public Elfo(string name)
        {
            this.name = name;
        }
        public string Name { get; set; }
        public int Daño { get => daño; set => daño = value; }
        public int Defensa { get => defensa; set => defensa = value; }

        //PLANTEO LOS METODOS PARA EVALUAR ENTRE TODOS EN CLASE

        public int RecibirDaño ()
        {
            return a;
        }
        
        public int Curarse ()
        {
            return a;
        }
        
        public int ObtenerDefensa ()
        {
            return a;
        }
        
        public int ObtenerAtaque ()
        {
            return a;
        }
        
        public int EquiparItem ()
        {
            return a;
        }
    }
}
