using Voluntario3.Models;

namespace Voluntario3.Tabelas
{
    /// <summary>
    /// Representa a tabela de alíquota do ano 2013.
    /// </summary>
    internal class TabelaAliquota2013 : TabelaBase
    {
        public TabelaAliquota2013()
            : base(teto: 457.49M)
        {
            Faixas.Add(new Faixa(1247.70M, Aliquotas.OitoPorcento));
            Faixas.Add(new Faixa(1247.71M, 2079.50M, Aliquotas.NovePorcento));
            Faixas.Add(new Faixa(2079.51M, 4159.00M, Aliquotas.OnzePorcento));
        }

        public override int Ano()
        {
            return 2013;
        }
    }
}