using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace InterfaceSegregation.Exemplo1.SeguindoPrincipio
{
    interface IPesquisaRepositorio<TEntidade>
    {
        TEntidade ObterPorCodigo(int codigo);
        TEntidade Obter(Expression<Func<TEntidade, bool>> condicao);
        IEnumerable<TEntidade> Listar();
        IEnumerable<TEntidade> Listar(Expression<Func<TEntidade, bool>> condicao);
    }
}
