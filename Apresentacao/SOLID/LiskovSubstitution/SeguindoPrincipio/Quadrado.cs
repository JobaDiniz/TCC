
namespace LiskovSubstitution.SeguindoPrincipio
{
    class Quadrado : Forma
    {
        public int Lado { get; set; }

        public override double Area()
        {
            return Lado * Lado;
        }

        public override void DobrarTamanho()
        {
            Lado *= 2;
        }
    }
}
