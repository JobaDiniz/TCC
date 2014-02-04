
namespace OpenClosed.DependencyInversion
{
    interface IRegraPreco
    {
        bool PodeCalcularPara(Item item);
        decimal Calcular(Item item);
    }
}
