
namespace OpenClosed.SeguindoPrincipio
{
    interface IRegraPreco
    {
        bool PodeCalcularPara(Item item);
        decimal Calcular(Item item);
    }
}
