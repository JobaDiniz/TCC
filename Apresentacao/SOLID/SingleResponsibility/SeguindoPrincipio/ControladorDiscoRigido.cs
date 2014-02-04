using System.IO;
using System.Threading.Tasks;

namespace SingleResponsibility.SeguindoPrincipio
{
    class ControladorDiscoRigido
    {
        public long CalcularEspacoEmDiscoUsado(string pasta)
        {
            var dir = new DirectoryInfo(pasta);
            if (!dir.Exists)
                return 0;

            long size = 0;
            Parallel.ForEach(dir.EnumerateFiles("*.*", SearchOption.AllDirectories), file =>
            {
                size += file.Length;
            });

            return size;
        }
    }
}
