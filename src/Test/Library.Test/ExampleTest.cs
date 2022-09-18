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
        public void Curar(){

        }

        [Test]
        public void AgregarItem(){

        }

        [Test]
        public void Pepe(){

        }
    }
}   