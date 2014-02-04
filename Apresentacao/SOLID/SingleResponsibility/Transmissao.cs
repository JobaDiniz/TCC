using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Transmissao
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Pasta { get; set; }
        public long EspacoEmDiscoUsado { get; set; }
    }
}
