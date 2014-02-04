using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace InterfaceSegregation.Exemplo1.PrincipioQuebrado
{
    interface IRepositorioBase<TEntidade>
    {
        void Salvar(TEntidade entidade);
        void Salvar(IEnumerable<TEntidade> entidades);
        void Excluir(TEntidade entidade);
        void Excluir(IEnumerable<TEntidade> entidades);
        TEntidade ObterPorCodigo(int codigo);
        TEntidade Obter(Expression<Func<TEntidade, bool>> condicao);
        IEnumerable<TEntidade> Listar();
        IEnumerable<TEntidade> Listar(Expression<Func<TEntidade,bool>> condicao);
    }
}
