using System.Linq;
using Voluntario4.Interface;
using Voluntario4.Tabelas;
using Interfaces;
using System.Collections.Generic;

namespace Voluntario4
{
    public class CalculadorINSS : ICalculadorINSS
    {
        private readonly IList<ITabelaAliquota> tabelas;

        public CalculadorINSS()
        {
            tabelas = new List<ITabelaAliquota>
                {
                    new TabelaAliquota2010(),
                    new TabelaAliquota2011(),
                    new TabelaAliquota2012(),
                    new TabelaAliquota2013(),
                    new TabelaAliquota2014()
                };
        }

        public decimal Calcular(int ano, decimal salario)
        {
            var tabela = tabelas.FirstOrDefault(t => t.PodeCalcularParaOAno(ano));

            return tabela != null ? tabela.CalcularDesconto(salario) : decimal.Zero;
        }
    }
}
