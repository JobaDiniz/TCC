using System;

namespace Voluntario2.Models
{
    /// <summary>
    /// Representa uma faixa da tabela de alíquota.
    /// </summary>
    internal class Faixa
    {
        private const int CasasDecimais = 2;

        private decimal valorInicial;
        private decimal valorFinal;
        private decimal aliquota;

        internal Faixa(decimal valor, decimal aliquota)
            : this(decimal.Zero, valor, aliquota) { }

        internal Faixa(decimal valorInicial, decimal valorFinal, decimal aliquota)
        {
            this.valorInicial = valorInicial;
            this.valorFinal = valorFinal;
            this.aliquota = aliquota;
        }

        /// <summary>
        /// Verifica se o salário especificado está dentro da faixa.
        /// </summary>
        internal bool SalarioEstaNaFaixa(decimal salario)
        {
            return salario >= valorInicial && salario <= valorFinal;
        }

        /// <summary>
        /// Aplica a alíquota em cima do salário especificado.
        /// </summary>
        internal decimal AplicarAliquota(decimal salario)
        {
            return Arrendondar(salario * aliquota);
        }

        private decimal Arrendondar(decimal valor)
        {
            return Math.Round(valor, CasasDecimais);
        }
    }
}
