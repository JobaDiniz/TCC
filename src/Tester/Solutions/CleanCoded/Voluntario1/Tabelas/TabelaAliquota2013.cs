using Voluntario1.Models;
using System.Collections.Generic;

namespace Voluntario1.Tabelas
{
    /// <summary>
    /// Representa a tabela de alíquota do ano 2011.
    /// </summary>
    internal class TabelaAliquota2013 : TabelaBase
    {
        public TabelaAliquota2013()
        {
            Faixas.Add(new Faixa(1247.70M, Aliquotas.OitoPorcento));
            Faixas.Add(new Faixa(1247.71M, 2079.50M, Aliquotas.NovePorcento));
            Faixas.Add(new Faixa(2079.51M, 4159.00M, Aliquotas.OnzePorcento));

            Teto = 457.49M;
        }

        public override bool PodeCalcularParaOAno(int ano)
        {
            return ano == 2013;
        }
    }
}
