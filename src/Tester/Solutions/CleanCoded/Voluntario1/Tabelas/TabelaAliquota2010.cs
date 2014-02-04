using Voluntario1.Models;

namespace Voluntario1.Tabelas
{
    /// <summary>
    /// Representa a tabela de alíquota do ano 2010.
    /// </summary>
    internal class TabelaAliquota2010 : TabelaBase
    {
        public TabelaAliquota2010()
        {
            Faixas.Add(new Faixa(1040.22M, Aliquotas.OitoPorcento));
            Faixas.Add(new Faixa(1040.23M, 1733.70M, Aliquotas.NovePorcento));
            Faixas.Add(new Faixa(1733.71M, 3467.40M, Aliquotas.OnzePorcento));

            Teto = 381.41M;
        }

        public override bool PodeCalcularParaOAno(int ano)
        {
            return ano == 2010;
        }
    }
}
