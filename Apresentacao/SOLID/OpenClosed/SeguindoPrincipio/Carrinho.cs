using System.Collections.Generic;

namespace OpenClosed.SeguindoPrincipio
{
    class Carrinho
    {
        private IList<Item> itens;
        private CalculadorPreco calculador;

        public Carrinho()
        {
            itens = new List<Item>();
            calculador = new CalculadorPreco();
        }

        public void AdicionarItem(Item item)
        {
            itens.Add(item);
        }

        public decimal Total()
        {
            decimal total = 0M;
            foreach (var item in itens)
                total += calculador.Calcular(item);

            return total;
        }
    }
}
