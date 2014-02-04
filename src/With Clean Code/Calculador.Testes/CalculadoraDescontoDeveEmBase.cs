using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculador.Testes
{
    [TestClass]
    public abstract class CalculadorINNSDeveEmBase
    {
        protected const decimal UM_CENTAVO = 0.01M;

        private ICalculadorINSS calculadorINSS;

        protected decimal? salarioEmValidacao;

        protected abstract int Ano { get; }

        public CalculadorINNSDeveEmBase()
        {
            calculadorINSS = new CalculadorINSS();
        }

        [TestInitialize]
        private void Inicializar()
        {
            salarioEmValidacao = null;
        }

        [TestCleanup]
        private void Limpar()
        {
        }

        protected void ParaOSalario(decimal salario)
        {
            salarioEmValidacao = salario;
        }

        protected void DeveTerAPorcentagemDeDesconto(decimal porcentagemDescontoEsperado)
        {
            GarantirSalarioEmValidacao();

            decimal valorDescontoInss = calculadorINSS.Calcular(Ano, salarioEmValidacao.Value);
            decimal porcentagemDesconto = CalcularPorcentagemArredondada(salarioEmValidacao.Value, valorDescontoInss);

            Assert.AreEqual(porcentagemDescontoEsperado / 100, porcentagemDesconto);
        }

        protected void DeveTerOValorDeDesconto(decimal valorEsperado)
        {
            GarantirSalarioEmValidacao();

            decimal valorDescontoInss = calculadorINSS.Calcular(Ano, salarioEmValidacao.Value);

            Assert.AreEqual(valorEsperado, valorDescontoInss);
        }

        private void GarantirSalarioEmValidacao()
        {
            if (!salarioEmValidacao.HasValue)
                throw new InvalidOperationException("Defina o salário em validação antes de verificar o desconto");
        }

        internal static decimal CalcularPorcentagemArredondada(decimal valorTotal, decimal valorParcial, int casas = 2)
        {
            if (valorTotal == 0)
                return decimal.Zero;

            return Math.Round(valorParcial / valorTotal, casas);
        }
    }

    /// <summary>
    /// Garante a qualidade dos métodos auxiliares de teste nos quais outros testes confiam
    /// Eu sei que nesse caso em especial é um teste meio inútil pois é so uma divisão, mas é só para ilustrar que metodos auxiliares aos testes tambem devem ser testados
    /// </summary>
    [TestClass]
    public class AplicarDescontoDeve
    {
        [TestMethod]
        public void RetornarZero_QuandoOValorEhZero()
        {
            Assert.AreEqual(0M, CalculadorINNSDeveEmBase.CalcularPorcentagemArredondada(0M, 0M));
        }

        [TestMethod]
        public void RetornarUmPorCento_ParaDezDeCem()
        {
            Assert.AreEqual(.1M, CalculadorINNSDeveEmBase.CalcularPorcentagemArredondada(100M, 10M));
        }

        [TestMethod]
        public void RetornarMeioPorCento_ParaCinquentaDeCem()
        {
            Assert.AreEqual(.5M, CalculadorINNSDeveEmBase.CalcularPorcentagemArredondada(100M, 50M));
        }

        [TestMethod]
        public void ArredondarValoresProximos()
        {
            decimal valorTotal = 6;
            decimal valorParcial = 10;

            decimal valorReal = 1.666666666666M;//..;
            decimal valorEsperado = 1.67M;
            // 1.666...

            Assert.AreEqual(valorEsperado, CalculadorINNSDeveEmBase.CalcularPorcentagemArredondada(valorTotal, valorParcial));
        }
    }
}