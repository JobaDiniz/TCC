using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculador
{
    public class CalculadorINSS : ICalculadorINSS
    {
        public decimal Calcular(int ano, decimal salario)
        {
            if (salario <= 0)
                return 0;
            else if (ano == 2010)
            {
                if (salario <= 1040.22M)
                    return Math.Round(salario * 8 / 100, 2);
                else if (salario >= 1040.23M && salario <= 1733.70M)
                    return Math.Round(salario * 9 / 100, 2);
                else if (salario >= 1733.71M && salario <= 3467.40M)
                    return Math.Round(salario * 11 / 100, 2);
                else
                    return 381.41M;
            }
            else if (ano == 2011)
            {
                if (salario <= 1106.90M)
                    return Math.Round(salario * 8 / 100, 2);
                else if (salario >= 1106.91M && salario <= 1844.43M)
                    return Math.Round(salario * 9 / 100, 2);
                else if (salario >= 1844.44M && salario <= 3689.66M)
                    return Math.Round(salario * 11 / 100, 2);
                else
                    return 405.86M;
            }
            else
            {
                return 0;
            }
        }
    }
}
