using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiskovSubstitution.SeguindoPrincipio
{
    [TestClass]
    public class TesteAreaSeguindoPrincipio
    {
        [TestMethod]
        public void Calculo_Da_Area_Apos_Dobrar_Tamanho_Do_Retangulo()
        {
            Forma forma = new Retangulo
            {
                Altura = 1,
                Largura = 2
            };

            forma.DobrarTamanho();
            var area = forma.Area();

            Assert.AreEqual(8, area);
        }

        [TestMethod]
        public void Calculo_Da_Area_Apos_Dobrar_Tamanho_Do_Quadrado()
        {
            Forma forma = new Quadrado { Lado = 1 };

            forma.DobrarTamanho();
            var area = forma.Area();

            Assert.AreEqual(4, area);
        }
    }
}
