using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace InterfaceSegregation.Exemplo1.SeguindoPrincipio
{
    class PessoaRepositorio : IPessoaRepositorio
    {
        public void Salvar(Pessoa entidade)
        {

        }

        public void Excluir(Pessoa entidade)
        {

        }

        public Pessoa ObterPorCodigo(int codigo)
        {
            return new Pessoa();
        }

        public IEnumerable<Pessoa> Listar()
        {
            return Enumerable.Empty<Pessoa>();
        }

        public IEnumerable<Pessoa> Listar(Expression<Func<Pessoa, bool>> condicao)
        {
            return Enumerable.Empty<Pessoa>();
        }


        public void Salvar(IEnumerable<Pessoa> entidades)
        {

        }

        public void Excluir(IEnumerable<Pessoa> entidades)
        {
            throw new NotImplementedException();
        }

        public Pessoa Obter(Expression<Func<Pessoa, bool>> condicao)
        {
            return new Pessoa();
        }
    }
}
