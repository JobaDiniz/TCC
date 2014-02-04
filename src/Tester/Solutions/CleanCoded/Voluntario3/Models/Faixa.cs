using System;

namespace Voluntario3.Models
{
    /// <summary>
    /// Representa uma faixa da tabela de alíquota.
    /// </summary>
    internal class Faixa
    {
        private const int CasasDecimais = 2;

        private readonly decimal _valorInicial;
        private readonly decimal _valorFinal;
        private readonly decimal _aliquota;

        internal Faixa(decimal valor, decimal aliquota)
            : this(decimal.Zero, valor, aliquota) { }

        internal Faixa(decimal valorInicial, decimal valorFinal, decimal aliquota)
        {
            _valorInicial = valorInicial;
            _valorFinal = valorFinal;
            _aliquota = aliquota;
        }

        /// <summary>
        /// Verifica se o salário especificado está dentro da faixa.
        /// </summary>
        internal bool SalarioEstaNaFaixa(decimal salario)
        {
            return salario >= _valorInicial && salario <= _valorFinal;
        }

        /// <summary>
        /// Aplica a alíquota em cima do salário especificado.
        /// </summary>
        internal decimal AplicarAliquota(decimal salario)
        {
            return Arrendondar(salario * _aliquota);
        }

        private decimal Arrendondar(decimal valor)
        {
            return Math.Round(valor, CasasDecimais);
        }
    }
}
