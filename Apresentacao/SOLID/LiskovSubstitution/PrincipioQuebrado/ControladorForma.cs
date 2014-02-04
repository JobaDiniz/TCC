
namespace LiskovSubstitution.PrincipioQuebrado
{
    static class ControladorForma
    {
        public static void DobrarTamanho(Retangulo retangulo)
        {
            retangulo.Altura *= 2;
            retangulo.Largura *= 2;
        }
    }
}
