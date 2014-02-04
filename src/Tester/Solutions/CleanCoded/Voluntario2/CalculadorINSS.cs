using Voluntario2.Interface;
using Voluntario2.Tabelas;
using Interfaces;
using System.Collections.Generic;

namespace Voluntario2
{
    public class CalculadorINSS : ICalculadorINSS
    {
        private IList<ITabelaAliquota> tabelas;

        public CalculadorINSS()
        {
            tabelas = new List<ITabelaAliquota>();
            tabelas.Add(new TabelaAliquota2010());
            tabelas.Add(new TabelaAliquota2011());
            tabelas.Add(new TabelaAliquota2012());
            tabelas.Add(new TabelaAliquota2013());
            tabelas.Add(new TabelaAliquota2014());
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
