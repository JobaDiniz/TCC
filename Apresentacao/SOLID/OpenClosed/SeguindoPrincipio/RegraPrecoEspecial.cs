
namespace OpenClosed.SeguindoPrincipio
{
    class RegraPrecoEspecial : IRegraPreco
    {
        public bool PodeCalcularPara(Item item)
        {
            return item.Unidade == UnidadeEstoque.Especial;
        }

        public decimal Calcular(Item item)
        {
            //R$ 0,40 cada. 3 por R$ 1,00
            var total = item.Quantidade * 0.4M;
            var conjuntosDeTres = item.Quantidade / 3;
            total -= conjuntosDeTres * 0.2M;

            return total;
        }
    }
}
