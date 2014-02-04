using System.Collections.Generic;

namespace OpenClosed.SeguindoPrincipio
{
    class CalculadorPreco
    {
        private IList<IRegraPreco> regras;

        public CalculadorPreco()
        {
            regras = new List<IRegraPreco>();
            regras.Add(new RegraPrecoEspecial());
            regras.Add(new RegraPrecoPorGrama());
            regras.Add(new RegraPrecoCada());
        }

        public decimal Calcular(Item item)
        {
            foreach (var regra in regras)
            {
                if (regra.PodeCalcularPara(item))
                    return regra.Calcular(item);
            }

            return decimal.Zero;
        }
    }
}
