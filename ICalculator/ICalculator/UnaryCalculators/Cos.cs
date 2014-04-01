using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator.UnaryCalculators
{
    class Cos : IUnaryCalculator
    {
        public string Calculate(double first)
        {
            double result = Math.Cos(first);
            return result.ToString();
        }
    }
}
