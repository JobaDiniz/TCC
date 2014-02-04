using Calculador.Interface;
using Calculador.Tabelas;
using Interfaces;
using System.Collections.Generic;

namespace Calculador
{
    public class CalculadorINSS : ICalculadorINSS
    {
        private IList<ITabelaAliquota> tabelas;

        public CalculadorINSS()
        {
            tabelas = new List<ITabelaAliquota>();
            tabelas.Add(new TabelaAliquota2010());
            tabelas.Add(new TabelaAliquota2011());
        }

        public decimal Calcular(int ano, decimal salario)
        {
            foreach (var tabela in tabelas)
            {
                if (tabela.PodeCalcularParaOAno(ano))
                    return tabela.CalcularDesconto(salario);
            }

            return decimal.Zero;
        }
    }
}
