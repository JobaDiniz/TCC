using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Voluntario2;

namespace Voluntario1Test
{
    [TestClass]
    public class Voluntario2Test
    {
        protected ICalculadorINSS Calculador;

        public Voluntario2Test()
        {
            Calculador = new CalculadorINSS();
        }

        [TestMethod]
        public void Retornar_Zero_Se_Salario_Igual_A_Zero()
        {
            //Act
            var desconto = Calculador.Calcular(2011, 0);
            //Assert
            Assert.AreEqual(0, desconto);
        }

        [TestMethod]
        public void Retornar_Zero_Se_Salario_For_Negativo()
        {
            //Act
            var desconto = Calculador.Calcular(2011, -10);
            //Assert
            Assert.AreEqual(0, desconto);
        }

        [TestMethod]
        public void Retornar_Zero_Se_Ano_For_Invalido()
        {
            //Act
            var desconto = Calculador.Calcular(2000, 100);
            //Assert
            Assert.AreEqual(0, desconto);
        }

        #region 2010
        [TestMethod]
        public void Retornar_8_Por_Cento_De_Desconto_Para_Salario_Igual_A_1040_22()
        {
            //Act
            var desconto = Calculador.Calcular(2010, 1040.22M);
            //Assert
            Assert.AreEqual(83.22M, desconto);
        }

        [TestMethod]
        public void Retornar_8_Por_Cento_De_Desconto_Para_Salario_Menor_Que_1040_22()
        {
            //Act
            var desconto = Calculador.Calcular(2010, 1000M);
            //Assert
            Assert.AreEqual(80M, desconto);
        }

        [TestMethod]
        public void Retornar_9_Por_Cento_De_Desconto_Para_Salario_Igual_A_1040_23()
        {
            //Act
            var desconto = Calculador.Calcular(2010, 1040.23M);
            //Assert
            Assert.AreEqual(93.62M, desconto);
        }

        [TestMethod]
        public void Retornar_9_Por_Cento_De_Desconto_Para_Salario_Igual_A_1733_70()
        {
            //Act
            var desconto = Calculador.Calcular(2010, 1733.70M);
            //Assert
            Assert.AreEqual(156.03M, desconto);
        }

        [TestMethod]
        public void Retornar_9_Por_Cento_De_Desconto_Para_Salario_Entre_A_Segunda_Faixa_Em_2010()
        {
            //Act
            var desconto = Calculador.Calcular(2010, 1500M);
            //Assert
            Assert.AreEqual(135M, desconto);
        }

        [TestMethod]
        public void Retornar_11_Por_Cento_De_Desconto_Para_Salario_Igual_A_1733_71()
        {
            //Act
            var desconto = Calculador.Calcular(2010, 1733.71M);
            //Assert
            Assert.AreEqual(190.71M, desconto);
        }

        [TestMethod]
        public void Retornar_11_Por_Cento_De_Desconto_Para_Salario_Igual_A_3467_40()
        {
            //Act
            var desconto = Calculador.Calcular(2010, 3467.40M);
            //Assert
            Assert.AreEqual(381.41M, desconto);
        }

        [TestMethod]
        public void Retornar_11_Por_Cento_De_Desconto_Para_Salario_Entre_A_Terceira_Faixa_Em_2010()
        {
            //Act
            var desconto = Calculador.Calcular(2010, 2000M);
            //Assert
            Assert.AreEqual(220M, desconto);
        }

        [TestMethod]
        public void Retornar_Teto_Para_Salario_Maior_Que_A_Ultima_Faixa_Em_2010()
        {
            //Act
            var desconto = Calculador.Calcular(2010, 4000M);
            //Assert
            Assert.AreEqual(381.41M, desconto);
        }
        #endregion

        #region 2011
        [TestMethod]
        public void Retornar_8_Por_Cento_De_Desconto_Para_Salario_Igual_A_1106_90()
        {
            //Act
            var desconto = Calculador.Calcular(2011, 1106.90M);
            //Assert
            Assert.AreEqual(88.55M, desconto);
        }

        [TestMethod]
        public void Retornar_8_Por_Cento_De_Desconto_Para_Salario_Menor_Que_1106_90()
        {
            //Act
            var desconto = Calculador.Calcular(2011, 1000M);
            //Assert
            Assert.AreEqual(80M, desconto);
        }

        [TestMethod]
        public void Retornar_9_Por_Cento_De_Desconto_Para_Salario_Igual_A_1106_91()
        {
            //Act
            var desconto = Calculador.Calcular(2011, 1106.91M);
            //Assert
            Assert.AreEqual(99.62M, desconto);
        }

        [TestMethod]
        public void Retornar_9_Por_Cento_De_Desconto_Para_Salario_Igual_A_1844_43()
        {
            //Act
            var desconto = Calculador.Calcular(2011, 1844.43M);
            //Assert
            Assert.AreEqual(166M, desconto);
        }

        [TestMethod]
        public void Retornar_9_Por_Cento_De_Desconto_Para_Salario_Entre_A_Segunda_Faixa_Em_2011()
        {
            //Act
            var desconto = Calculador.Calcular(2011, 1500M);
            //Assert
            Assert.AreEqual(135M, desconto);
        }

        [TestMethod]
        public void Retornar_11_Por_Cento_De_Desconto_Para_Salario_Igual_A_1844_44()
        {
            //Act
            var desconto = Calculador.Calcular(2011, 1844.44M);
            //Assert
            Assert.AreEqual(202.89M, desconto);
        }

        [TestMethod]
        public void Retornar_11_Por_Cento_De_Desconto_Para_Salario_Igual_A_3689_66()
        {
            //Act
            var desconto = Calculador.Calcular(2011, 3689.66M);
            //Assert
            Assert.AreEqual(405.86M, desconto);
        }

        [TestMethod]
        public void Retornar_11_Por_Cento_De_Desconto_Para_Salario_Entre_A_Terceira_Faixa_Em_2011()
        {
            //Act
            var desconto = Calculador.Calcular(2011, 2000M);
            //Assert
            Assert.AreEqual(220M, desconto);
        }

        [TestMethod]
        public void Retornar_Teto_Para_Salario_Maior_Que_A_Ultima_Faixa_Em_2011()
        {
            //Act
            var desconto = Calculador.Calcular(2011, 4000M);
            //Assert
            Assert.AreEqual(405.86M, desconto);
        }
        #endregion

        #region 2012
        [TestMethod]
        public void Retornar_8_Por_Cento_De_Desconto_Para_Salario_Igual_A_1174_86()
        {
            //Act
            var desconto = Calculador.Calcular(2012, 1174.86M);
            //Assert
            Assert.AreEqual(93.99M, desconto);
        }

        [TestMethod]
        public void Retornar_8_Por_Cento_De_Desconto_Para_Salario_Menor_Que_1174_86()
        {
            //Act
            var desconto = Calculador.Calcular(2012, 1000M);
            //Assert
            Assert.AreEqual(80M, desconto);
        }

        [TestMethod]
        public void Retornar_9_Por_Cento_De_Desconto_Para_Salario_Igual_A_1174_87()
        {
            //Act
            var desconto = Calculador.Calcular(2012, 1174.87M);
            //Assert
            Assert.AreEqual(105.74M, desconto);
        }

        [TestMethod]
        public void Retornar_9_Por_Cento_De_Desconto_Para_Salario_Igual_A_1958_10()
        {
            //Act
            var desconto = Calculador.Calcular(2012, 1958.10M);
            //Assert
            Assert.AreEqual(176.23M, desconto);
        }

        [TestMethod]
        public void Retornar_9_Por_Cento_De_Desconto_Para_Salario_Entre_A_Segunda_Faixa_Em_2012()
        {
            //Act
            var desconto = Calculador.Calcular(2012, 1500M);
            //Assert
            Assert.AreEqual(135M, desconto);
        }

        [TestMethod]
        public void Retornar_11_Por_Cento_De_Desconto_Para_Salario_Igual_A_1958_11()
        {
            //Act
            var desconto = Calculador.Calcular(2012, 1958.11M);
            //Assert
            Assert.AreEqual(215.39M, desconto);
        }

        [TestMethod]
        public void Retornar_11_Por_Cento_De_Desconto_Para_Salario_Igual_A_3916_20()
        {
            //Act
            var desconto = Calculador.Calcular(2012, 3916.20M);
            //Assert
            Assert.AreEqual(430.78M, desconto);
        }

        [TestMethod]
        public void Retornar_11_Por_Cento_De_Desconto_Para_Salario_Entre_A_Terceira_Faixa_Em_2012()
        {
            //Act
            var desconto = Calculador.Calcular(2012, 2000M);
            //Assert
            Assert.AreEqual(220M, desconto);
        }

        [TestMethod]
        public void Retornar_Teto_Para_Salario_Maior_Que_A_Ultima_Faixa_Em_2012()
        {
            //Act
            var desconto = Calculador.Calcular(2012, 4000M);
            //Assert
            Assert.AreEqual(430.78M, desconto);
        }
        #endregion

        #region 2013
        [TestMethod]
        public void Retornar_8_Por_Cento_De_Desconto_Para_Salario_Igual_A_1247_70()
        {
            //Act
            var desconto = Calculador.Calcular(2013, 1247.70M);
            //Assert
            Assert.AreEqual(99.82M, desconto);
        }

        [TestMethod]
        public void Retornar_8_Por_Cento_De_Desconto_Para_Salario_Menor_Que_1247_70()
        {
            //Act
            var desconto = Calculador.Calcular(2013, 1000M);
            //Assert
            Assert.AreEqual(80M, desconto);
        }

        [TestMethod]
        public void Retornar_9_Por_Cento_De_Desconto_Para_Salario_Igual_A_1247_71()
        {
            //Act
            var desconto = Calculador.Calcular(2013, 1247.71M);
            //Assert
            Assert.AreEqual(112.29M, desconto);
        }

        [TestMethod]
        public void Retornar_9_Por_Cento_De_Desconto_Para_Salario_Igual_A_2079_50()
        {
            //Act
            var desconto = Calculador.Calcular(2013, 2079.50M);
            //Assert
            Assert.AreEqual(187.16M, desconto);
        }

        [TestMethod]
        public void Retornar_9_Por_Cento_De_Desconto_Para_Salario_Entre_A_Segunda_Faixa_Em_2013()
        {
            //Act
            var desconto = Calculador.Calcular(2013, 1500M);
            //Assert
            Assert.AreEqual(135M, desconto);
        }

        [TestMethod]
        public void Retornar_11_Por_Cento_De_Desconto_Para_Salario_Igual_A_2079_51()
        {
            //Act
            var desconto = Calculador.Calcular(2013, 2079.51M);
            //Assert
            Assert.AreEqual(228.75M, desconto);
        }

        [TestMethod]
        public void Retornar_11_Por_Cento_De_Desconto_Para_Salario_Igual_A_4159()
        {
            //Act
            var desconto = Calculador.Calcular(2013, 4159M);
            //Assert
            Assert.AreEqual(457.49M, desconto);
        }

        [TestMethod]
        public void Retornar_11_Por_Cento_De_Desconto_Para_Salario_Entre_A_Terceira_Faixa_Em_2013()
        {
            //Act
            var desconto = Calculador.Calcular(2013, 3000M);
            //Assert
            Assert.AreEqual(330M, desconto);
        }

        [TestMethod]
        public void Retornar_Teto_Para_Salario_Maior_Que_A_Ultima_Faixa_Em_2013()
        {
            //Act
            var desconto = Calculador.Calcular(2013, 5000M);
            //Assert
            Assert.AreEqual(457.49M, desconto);
        }
        #endregion

        #region 2014
        [TestMethod]
        public void Retornar_8_Por_Cento_De_Desconto_Para_Salario_Igual_A_1300()
        {
            //Act
            var desconto = Calculador.Calcular(2014, 1300M);
            //Assert
            Assert.AreEqual(104M, desconto);
        }

        [TestMethod]
        public void Retornar_8_Por_Cento_De_Desconto_Para_Salario_Menor_Que_1300()
        {
            //Act
            var desconto = Calculador.Calcular(2014, 1000M);
            //Assert
            Assert.AreEqual(80M, desconto);
        }

        [TestMethod]
        public void Retornar_9_Por_Cento_De_Desconto_Para_Salario_Igual_A_1300_01()
        {
            //Act
            var desconto = Calculador.Calcular(2014, 1300.01M);
            //Assert
            Assert.AreEqual(117M, desconto);
        }

        [TestMethod]
        public void Retornar_9_Por_Cento_De_Desconto_Para_Salario_Igual_A_2300()
        {
            //Act
            var desconto = Calculador.Calcular(2014, 2300M);
            //Assert
            Assert.AreEqual(207M, desconto);
        }

        [TestMethod]
        public void Retornar_9_Por_Cento_De_Desconto_Para_Salario_Entre_A_Segunda_Faixa_Em_2014()
        {
            //Act
            var desconto = Calculador.Calcular(2014, 1500M);
            //Assert
            Assert.AreEqual(135M, desconto);
        }

        [TestMethod]
        public void Retornar_12_Por_Cento_De_Desconto_Para_Salario_Igual_A_2300_01()
        {
            //Act
            var desconto = Calculador.Calcular(2014, 2300.01M);
            //Assert
            Assert.AreEqual(276M, desconto);
        }

        [TestMethod]
        public void Retornar_12_Por_Cento_De_Desconto_Para_Salario_Igual_A_4300()
        {
            //Act
            var desconto = Calculador.Calcular(2014, 4300M);
            //Assert
            Assert.AreEqual(516M, desconto);
        }

        [TestMethod]
        public void Retornar_12_Por_Cento_De_Desconto_Para_Salario_Entre_A_Terceira_Faixa_Em_2014()
        {
            //Act
            var desconto = Calculador.Calcular(2014, 3000M);
            //Assert
            Assert.AreEqual(360M, desconto);
        }

        [TestMethod]
        public void Retornar_Teto_Para_Salario_Maior_Que_A_Ultima_Faixa_Em_2014()
        {
            //Act
            var desconto = Calculador.Calcular(2014, 5000M);
            //Assert
            Assert.AreEqual(516M, desconto);
        }
        #endregion
    }
}
