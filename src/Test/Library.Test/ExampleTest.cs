using NUnit.Framework;
using Program;

namespace Test.Library
{
    public class ExampleTest
    {
        
        [Test]
        public void RecibirDanio1()
        {
            int expected = 90;
            Elfo legolas = new Elfo ("Legolas", 100, 10, 0, null, null);
            Enano enanoVirgo1  = new Enano("Tony", 100 , 10, 10);
            legolas.RecibirDanio(enanoVirgo1.Danio);
            Assert.AreEqual(legolas.Vida, expected); 
       
        }

        [Test]
        public void RecibirDanioMal()
        {
            int expected = 1000;
            Elfo legolas = new Elfo ("Legolas", 100, 10, 0, null, null);
            Enano enanoVirgo1  = new Enano("Tony", 100 , 10, 10);
            legolas.RecibirDanio(enanoVirgo1.Danio);
            Assert.AreNotEqual(legolas.Vida, expected); 
       
        }


        [Test]
        public void CurarCorrecto(){

            int expected = 100;
            Elfo legolas = new Elfo ("Legolas", 100, 100,100, null,null);
            Enano enanoVirgo1  = new Enano("Tony", 100 , 10, 10);
            legolas.RecibirDanio(enanoVirgo1.Danio);
            legolas.Curarse();
            Assert.AreEqual(legolas.Vida, expected); 

        }

        [Test]
        public void AgregarBaston(){
            
            int expected = 110; // Esto es la suma del danio del baston (10) + el danio base del mago (100) = 110
            Baston pepe = new Baston(10,"Pepe");
            Mago gandalf = new Mago ("Gandalf", 100, 100,100, pepe,null);
            gandalf.EquiparBaston();
            Assert.AreEqual(gandalf.Danio,expected);

        }

        [Test]
        public void Pepe(){

        }
    }
}   