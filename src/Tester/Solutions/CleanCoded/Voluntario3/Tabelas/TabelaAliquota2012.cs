using Voluntario3.Models;

namespace Voluntario3.Tabelas
{
    /// <summary>
    /// Representa a tabela de alíquota do ano 2012.
    /// </summary>
    internal class TabelaAliquota2012 : TabelaBase
    {
        public TabelaAliquota2012()
            : base(teto: 430.78M)
        {
            Faixas.Add(new Faixa(1174.86M, Aliquotas.OitoPorcento));
            Faixas.Add(new Faixa(1174.87M, 1958.10M, Aliquotas.NovePorcento));
            Faixas.Add(new Faixa(1958.11M, 3916.20M, Aliquotas.OnzePorcento));
        }

        public override int Ano()
        {
            return 2012;
        }
    }
}