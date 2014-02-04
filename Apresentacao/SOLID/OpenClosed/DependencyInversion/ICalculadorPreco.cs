using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosed.DependencyInversion
{
    interface ICalculadorPreco
    {
        decimal Calcular(Item item);
    }
}
