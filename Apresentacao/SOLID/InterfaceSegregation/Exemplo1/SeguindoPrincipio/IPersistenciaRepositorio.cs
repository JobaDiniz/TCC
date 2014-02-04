using System.Collections.Generic;

namespace InterfaceSegregation.Exemplo1.SeguindoPrincipio
{
    interface IPersistenciaRepositorio<TEntidade>
    {
        void Salvar(TEntidade entidade);
        void Salvar(IEnumerable<TEntidade> entidades);
        void Excluir(TEntidade entidade);
        void Excluir(IEnumerable<TEntidade> entidades);
    }
}
