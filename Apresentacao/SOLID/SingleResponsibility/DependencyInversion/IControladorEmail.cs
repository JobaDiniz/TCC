﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.DependencyInversion
{
    interface IControladorEmail
    {
        void EnviarErro(Exception ex);
    }
}
