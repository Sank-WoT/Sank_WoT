using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator.UnaryCalculators
{
    class Sqrt: IUnaryCalculator
    {
        public string Calculate(double first)
        {
            double result = Math.Pow(first, 0.5);
            return result.ToString();
        }
    }
}
