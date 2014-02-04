using Voluntario1.Interface;
using Voluntario1.Models;
using System.Collections.Generic;

namespace Voluntario1.Tabelas
{
    /// <summary>
    /// Representa a base de todas as tabelas de alíquotas.
    /// </summary>
    internal abstract class TabelaBase : ITabelaAliquota
    {
        protected decimal Teto { get; set; }
        protected IList<Faixa> Faixas { get; private set; }

        public abstract bool PodeCalcularParaOAno(int ano);

        public TabelaBase()
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
