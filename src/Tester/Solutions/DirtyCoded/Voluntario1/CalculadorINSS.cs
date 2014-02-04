using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voluntario1
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
            else if(ano == 2012)
            {
                if (salario <= 1174.86M)
                    return Math.Round(salario * 8 / 100, 2);
                else if (salario >= 1174.87M && salario <= 1958.10M)
                    return Math.Round(salario * 9 / 100, 2);
                else if (salario >= 1958.11M && salario <= 3916.20M)
                    return Math.Round(salario * 11 / 100, 2);
                else
                    return 430.78M;
            }
            else if (ano == 2013)
            {
                if (salario <= 1247.70M)
                    return Math.Round(salario * 8 / 100, 2);
                else if (salario >= 1247.71M && salario <= 2079.50M)
                    return Math.Round(salario * 9 / 100, 2);
                else if (salario >= 2079.51M && salario <= 4159.00M)
                    return Math.Round(salario * 11 / 100, 2);
                else
                    return 457.49M;
            }
            else if (ano == 2014)
            {
                if (salario <= 1300.00M)
                    return Math.Round(salario * 8 / 100, 2);
                else if (salario >= 1300.01M && salario <= 2300.00M)
                    return Math.Round(salario * 9 / 100, 2);
                else if (salario >= 2300.01M && salario <= 4300.00M)
                    return Math.Round(salario * 12 / 100, 2);
                else
                    return 516.00M;
            }
            else
            {
                return 0;
            }
        }
    }
}
