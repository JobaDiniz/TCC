using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Ruim
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
            //se possuir espaço, adiciona.
            if (livros.Count + 1 <= capacidade)
                livros.Add(livro);
            else
                throw new InvalidOperationException("A prateleira está cheia");
        }
    }
}
