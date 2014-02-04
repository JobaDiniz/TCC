using System.Linq;
using System.Collections.Generic;

namespace OpenClosed.DependencyInversion
{
    class CalculadorPreco : ICalculadorPreco
    {
        private IList<IRegraPreco> regras;

        public CalculadorPreco(IEnumerable<IRegraPreco> regras)
        {
            this.regras = regras.ToList();
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
