using Voluntario3.Interface;
using Voluntario3.Tabelas;
using Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Voluntario3
{
    public class CalculadorINSS : ICalculadorINSS
    {
        private readonly IList<ITabelaAliquota> _tabelas;

        public CalculadorINSS()
        {
            _tabelas = new List<ITabelaAliquota>
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
            return _tabelas.All(c => c.Ano() != ano) ? decimal.Zero : _tabelas.First(t => t.Ano() == ano).CalcularDesconto(salario);
        }
    }
}
