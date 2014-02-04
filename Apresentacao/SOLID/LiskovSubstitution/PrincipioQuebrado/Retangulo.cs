
namespace LiskovSubstitution.PrincipioQuebrado
{
    class Retangulo
    {
        public virtual int Altura { get; set; }
        public virtual int Largura { get; set; }

        public virtual double Area()
        {
            return Altura * Largura;
        }
    }
}
