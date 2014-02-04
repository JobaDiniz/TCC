using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.PrincipioQuebrado
{
    class Quadrado : Retangulo
    {
        private int altura;
        private int largura;

        public override int Altura
        {
            get { return altura; }
            set
            {
                altura = value;
                largura = value;
            }
        }

        public override int Largura
        {
            get { return largura; }
            set
            {
                largura = value;
                altura = value;
            }
        }

        public override double Area()
        {
            return altura * altura;
        }
    }
}
