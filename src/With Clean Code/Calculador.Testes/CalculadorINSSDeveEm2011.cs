using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculador.Testes
{
    [TestClass]
    public class CalculadorINSSDeveEm2011 : CalculadorINNSDeveEmBase
    {
        protected override int Ano { get { return 2011; } }
        private const decimal LIMITE_DA_PRIMEIRA_FAIXA = 1106.90M;
        private const decimal TETO = 405.86M;

        private const decimal INICIO_DA_SEGUNDA_FAIXA = 1106.91M;
        private const decimal MEIO_DA_SEGUNDA_FAIXA = (INICIO_DA_SEGUNDA_FAIXA + LIMITE_DA_SEGUNDA_FAIXA) / 2;
        private const decimal LIMITE_DA_SEGUNDA_FAIXA = 1844.43M;

        private const decimal INICIO_DA_ULTIMA_FAIXA = 1844.44M;
        private const decimal MEIO_DA_ULTIMA_FAIXA = (INICIO_DA_ULTIMA_FAIXA + LIMITE_DA_ULTIMA_FAIXA) / 2;
        private const decimal LIMITE_DA_ULTIMA_FAIXA = 3689.66M;

        [TestMethod]
        public void Retornar8PorCento_ParaSalariosMenoresQueAPrimeiraFaixa()
        {
            ParaOSalario(LIMITE_DA_PRIMEIRA_FAIXA - UM_CENTAVO);
            DeveTerAPorcentagemDeDesconto(8M);
        }

        [TestMethod]
        public void Retornar8PorCento_ParaSalariosNoLimiteDaPrimeiraFaixa()
        {
            ParaOSalario(LIMITE_DA_PRIMEIRA_FAIXA);
            DeveTerAPorcentagemDeDesconto(8M);
        }

        [TestMethod]
        public void Retornar9PorCento_ParaSalariosNoInicioDaSegundaFaixa()
        {
            ParaOSalario(INICIO_DA_SEGUNDA_FAIXA);
            DeveTerAPorcentagemDeDesconto(9M);
        }

        [TestMethod]
        public void Retornar9PorCento_ParaSalariosNaSegundaFaixa()
        {
            ParaOSalario(MEIO_DA_SEGUNDA_FAIXA);
            DeveTerAPorcentagemDeDesconto(9M);
        }

        [TestMethod]
        public void Retornar9PorCento_ParaSalariosNoLimiteDaSegundaFaixa()
        {
            ParaOSalario(LIMITE_DA_SEGUNDA_FAIXA);
            DeveTerAPorcentagemDeDesconto(9M);
        }

        [TestMethod]
        public void Retornar11PorCento_ParaSalariosNoInicioDaUltimaFaixa()
        {
            ParaOSalario(INICIO_DA_ULTIMA_FAIXA);
            DeveTerAPorcentagemDeDesconto(11M);
        }

        [TestMethod]
        public void Retornar11PorCento_ParaSalariosNaUltimaFaixa()
        {
            ParaOSalario(MEIO_DA_ULTIMA_FAIXA);
            DeveTerAPorcentagemDeDesconto(11M);
        }

        [TestMethod]
        public void Retornar11PorCento_ParaSalariosNoLimiteDaUltimaFaixa()
        {
            ParaOSalario(LIMITE_DA_ULTIMA_FAIXA);
            DeveTerAPorcentagemDeDesconto(11M);
        }

        [TestMethod]
        public void Retornar11PorCento_ParaSalariosMaioresQueAUltimaFaixa()
        {
            ParaOSalario(LIMITE_DA_ULTIMA_FAIXA + UM_CENTAVO);
            DeveTerOValorDeDesconto(TETO);
        }
    }
}
