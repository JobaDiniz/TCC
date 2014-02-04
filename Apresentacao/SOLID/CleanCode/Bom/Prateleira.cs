using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Bom
{
    class Prateleira
    {
        private int capacidade = 20;
        private IList<Livro> livros;

        public Prateleira()
        {
            livros = new List<Livro>(capacidade);
        }

        public void Adicionar(Livro livro)
        {
            if (PossuiEspacoDisponivel())
                livros.Add(livro);
            else
                throw new InvalidOperationException("A prateleira está cheia");
        }

        private bool PossuiEspacoDisponivel()
        {
            return livros.Count < capacidade;
        }
    }
}
