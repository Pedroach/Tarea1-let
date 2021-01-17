using NUnit.Framework;
using WebLetra.Controllers;

namespace NUnitTestLetra
{
    public class TestLetra
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Letra()
        {
            //Arrange=preparacion
            string num1 = "5";
            string esperado = "Cinco";
            LetraController lit = new LetraController();


            //Act=ejecution
            string resultado = lit.numeroget(num1);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);
        }
    }
}