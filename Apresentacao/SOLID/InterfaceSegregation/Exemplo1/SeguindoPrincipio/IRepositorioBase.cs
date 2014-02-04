
namespace InterfaceSegregation.Exemplo1.SeguindoPrincipio
{
    interface IRepositorioBase<TEntidade> : IPersistenciaRepositorio<TEntidade>, IPesquisaRepositorio<TEntidade>
    {
    }
}
