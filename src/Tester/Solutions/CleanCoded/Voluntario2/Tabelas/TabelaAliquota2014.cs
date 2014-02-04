using Voluntario2.Models;
using System.Collections.Generic;

namespace Voluntario2.Tabelas
{
    /// <summary>
    /// Representa a tabela de alíquota do ano 2011.
    /// </summary>
    internal class TabelaAliquota2014 : TabelaBase
    {
        public TabelaAliquota2014()
        {
            Faixas.Add(new Faixa(1300.00M, Aliquotas.OitoPorcento));
            Faixas.Add(new Faixa(1300.01M, 2300.00M, Aliquotas.NovePorcento));
            Faixas.Add(new Faixa(2300.01M, 4300.00M, 0.12M));

            Teto = 516.00M;
        }

        public override bool PodeCalcularParaOAno(int ano)
        {
            return ano == 2014;
        }
    }
}
