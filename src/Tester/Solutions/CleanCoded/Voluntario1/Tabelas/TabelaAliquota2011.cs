using System.Collections.Generic;
using Voluntario1.Models;

namespace Voluntario1.Tabelas
{
    /// <summary>
    /// Representa a tabela de alíquota do ano 2011.
    /// </summary>
    internal class TabelaAliquota2011 : TabelaBase
    {
        public TabelaAliquota2011()
        {
            Faixas.Add(new Faixa(1106.90M, Aliquotas.OitoPorcento));
            Faixas.Add(new Faixa(1106.91M, 1844.43M, Aliquotas.NovePorcento));
            Faixas.Add(new Faixa(1844.44M, 3689.66M, Aliquotas.OnzePorcento));

            Teto = 405.86M;
        }

        public override bool PodeCalcularParaOAno(int ano)
        {
            return ano == 2011;
        }
    }
}
