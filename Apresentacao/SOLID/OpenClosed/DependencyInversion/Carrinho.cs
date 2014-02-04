using System.Collections.Generic;

namespace OpenClosed.DependencyInversion
{
    class Carrinho
    {
        private IList<Item> itens;
        private ICalculadorPreco calculadorPreco;

        public Carrinho(ICalculadorPreco calculadorPreco)
        {
            itens = new List<Item>();
            this.calculadorPreco = calculadorPreco;
        }

        public void AdicionarItem(Item item)
        {
            itens.Add(item);
        }

        public decimal Total()
        {
            decimal total = 0M;
            foreach (var item in itens)
                total += calculadorPreco.Calcular(item);

            return total;
        }
    }
}
