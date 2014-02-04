using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.DependencyInversion
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Testing_Unity()
        {
            IUnityContainer unity = new UnityContainer();
            unity.RegisterType<IRegraPreco, RegraPrecoCada>(typeof(RegraPrecoCada).Name);
            unity.RegisterType<IRegraPreco, RegraPrecoEspecial>(typeof(RegraPrecoEspecial).Name);
            unity.RegisterType<IRegraPreco, RegraPrecoPorGrama>(typeof(RegraPrecoPorGrama).Name);
            unity.RegisterType<IEnumerable<IRegraPreco>, IRegraPreco[]>();

            unity.RegisterType<ICalculadorPreco, CalculadorPreco>();

            var carrinho = unity.Resolve<Carrinho>();
        }
    }
}
