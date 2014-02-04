
namespace LiskovSubstitution.SeguindoPrincipio
{
    class Retangulo : Forma
    {
        public int Altura { get; set; }
        public int Largura { get; set; }

        public override double Area()
        {
            return Altura * Largura;
        }

        public override void DobrarTamanho()
        {
            Altura *= 2;
            Largura *= 2;
        }
    }
}
