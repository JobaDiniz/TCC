
namespace OpenClosed.SeguindoPrincipio
{
    class RegraPrecoPorGrama : IRegraPreco
    {
        public bool PodeCalcularPara(Item item)
        {
            return item.Unidade == UnidadeEstoque.Peso;
        }

        public decimal Calcular(Item item)
        {
            //preço R$ 4,00 por kg
            //quantidade em gramas. 1kg -> 1000g então:
            return item.Quantidade * 4M / 1000;
        }
    }
}
