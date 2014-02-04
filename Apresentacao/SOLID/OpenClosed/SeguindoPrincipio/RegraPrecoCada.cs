
namespace OpenClosed.SeguindoPrincipio
{
    class RegraPrecoCada : IRegraPreco
    {
        public bool PodeCalcularPara(Item item)
        {
            return item.Unidade == UnidadeEstoque.Cada;
        }

        public decimal Calcular(Item item)
        {
            return item.Quantidade * 5M; //preço R$ 5,00
        }
    }
}
