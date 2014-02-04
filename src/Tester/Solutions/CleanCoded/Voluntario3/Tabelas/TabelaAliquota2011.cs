using Voluntario3.Models;

namespace Voluntario3.Tabelas
{
    /// <summary>
    /// Representa a tabela de alíquota do ano 2011.
    /// </summary>
    internal class TabelaAliquota2011 : TabelaBase
    {
        public TabelaAliquota2011()
            : base(teto: 405.86M)
        {
            Faixas.Add(new Faixa(1106.90M, Aliquotas.OitoPorcento));
            Faixas.Add(new Faixa(1106.91M, 1844.43M, Aliquotas.NovePorcento));
            Faixas.Add(new Faixa(1844.44M, 3689.66M, Aliquotas.OnzePorcento));
        }

        public override int Ano()
        {
            return 2011;
        }
    }
}
