using Voluntario3.Interface;
using Voluntario3.Models;
using System.Collections.Generic;

namespace Voluntario3.Tabelas
{
    /// <summary>
    /// Representa a base de todas as tabelas de alíquotas.
    /// </summary>
    internal abstract class TabelaBase : ITabelaAliquota
    {
        protected decimal Teto { get; private set; }
        protected IList<Faixa> Faixas { get; private set; }

        public abstract int Ano();

        protected TabelaBase(decimal teto)
            : this()
        {
            Teto = teto;
        }

        private TabelaBase()
        {
            Faixas = new List<Faixa>();
        }

        public decimal CalcularDesconto(decimal salario)
        {
            if (salario <= decimal.Zero)
                return decimal.Zero;

            foreach (var faixa in Faixas)
            {
                if (faixa.SalarioEstaNaFaixa(salario))
                    return faixa.AplicarAliquota(salario);
            }

            return Teto;
        }

        
    }
}
