using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculador.Testes
{
    [TestClass]
    public class CalculadorINSSDeve
    {
        private ICalculadorINSS calculadorINSS;

        public CalculadorINSSDeve()
        {
            calculadorINSS = new CalculadorINSS();
        }

         [TestMethod]
        public void Retornar_Zero_Se_Salario_Igual_A_Zero()
        {
            //Act
            var desconto = calculadorINSS.Calcular(2011, 0);
            //Assert
            Assert.AreEqual(0, desconto);
        }

        [TestMethod]
        public void Retornar_Zero_Se_Salario_For_Negativo()
        {
            //Act
            var desconto = calculadorINSS.Calcular(2011, -10);
            //Assert
            Assert.AreEqual(0, desconto);
        }

        [TestMethod]
        public void Retornar_Zero_Se_Ano_For_Diferente_De_2010_e_2011()
        {
            //Act
            var desconto = calculadorINSS.Calcular(2000, 100);
            //Assert
            Assert.AreEqual(0, desconto);
        }
    }
}
