using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiskovSubstitution.PrincipioQuebrado
{
    [TestClass]
    public class TesteAreaPrincipioQuebrado
    {
        [TestMethod]
        public void Calculo_Da_Area_Apos_Dobrar_Tamanho_Do_Retangulo()
        {
            Retangulo retangulo = new Retangulo
            {
                Altura = 1,
                Largura = 2
            };
            ControladorForma.DobrarTamanho(retangulo);

            var area = retangulo.Area();

            Assert.AreEqual(8, area);
        }

        [TestMethod]
        public void Calculo_Da_Area_Apos_Dobrar_Tamanho_Do_Quadrado()
        {
            Retangulo retangulo = new Quadrado
            {
                Altura = 1,
                Largura = 1
            };
            ControladorForma.DobrarTamanho(retangulo);

            var area = retangulo.Area();

            Assert.AreEqual(4, area);
        }
    }
}
