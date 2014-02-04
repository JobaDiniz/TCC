using Voluntario4.Models;

namespace Voluntario4.Tabelas
{
    /// <summary>
    /// Representa a tabela de alíquota do ano 2014.
    /// </summary>
    internal class TabelaAliquota2014 : TabelaBase
    {
        public TabelaAliquota2014()
        {
            Faixas.Add(new Faixa(1300M, Aliquotas.OitoPorcento));
            Faixas.Add(new Faixa(1300.01M, 2300M, Aliquotas.NovePorcento));
            Faixas.Add(new Faixa(2300.01M, 4300M, Aliquotas.DozePorcento));

            Teto = 516M;
        }

        public override bool PodeCalcularParaOAno(int ano)
        {
            return ano == 2014;
        }
    }
}
