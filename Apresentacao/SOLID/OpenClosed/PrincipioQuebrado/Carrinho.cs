using System.Collections.Generic;

namespace OpenClosed.PrincipioQuebrado
{
    class Carrinho
    {
        private IList<Item> itens;

        public Carrinho()
        {
            itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            itens.Add(item);
        }

        public decimal Total()
        {
            var total = 0M;
            foreach (var item in itens)
            {
                if (item.Unidade == UnidadeEstoque.Cada)
                    total += item.Quantidade * 5M; //preço R$ 5,00
                else if (item.Unidade == UnidadeEstoque.Peso)
                {
                    //preço R$ 4,00 por kg
                    //quantidade em gramas. 1kg -> 1000g então:
                    total += item.Quantidade * 4M / 1000;
                }
                else if (item.Unidade == UnidadeEstoque.Especial)
                {
                    //R$ 0,40 cada. 3 por R$ 1,00
                    total += item.Quantidade * 0.4M;
                    var conjuntosDeTres = item.Quantidade / 3;
                    total -= conjuntosDeTres * 0.2M;
                }
            }

            return total;
        }
    }
}
