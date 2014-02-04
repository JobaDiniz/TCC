using Voluntario1.Models;
using System.Collections.Generic;

namespace Voluntario1.Tabelas
{
    /// <summary>
    /// Representa a tabela de alíquota do ano 2011.
    /// </summary>
    internal class TabelaAliquota2012 : TabelaBase
    {
        public TabelaAliquota2012()
        {
            Faixas.Add(new Faixa(1174.86M, Aliquotas.OitoPorcento));
            Faixas.Add(new Faixa(1174.87M, 1958.10M, Aliquotas.NovePorcento));
            Faixas.Add(new Faixa(1958.11M, 3916.20M, Aliquotas.OnzePorcento));

            Teto = 430.78M;
        }

        public override bool PodeCalcularParaOAno(int ano)
        {
            return ano == 2012;
        }
    }
}
