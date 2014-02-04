using Voluntario3.Models;

namespace Voluntario3.Tabelas
{
    /// <summary>
    /// Representa a tabela de alíquota do ano 2014.
    /// </summary>
    internal class TabelaAliquota2014 : TabelaBase
    {
        public TabelaAliquota2014()
            : base(teto: 516.00M)
        {
            Faixas.Add(new Faixa(1300.00M, Aliquotas.OitoPorcento));
            Faixas.Add(new Faixa(1300.01M, 2300.00M, Aliquotas.NovePorcento));
            Faixas.Add(new Faixa(2300.01M, 4300.00M, Aliquotas.DozePorcento));
        }

        public override int Ano()
        {
            return 2014;
        }
    }
}