using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator.UnaryCalculators
{
    class Tan : IUnaryCalculator
    {
        public string Calculate(double first)
        {
            double result = Math.Tan(first);
            return result.ToString();
        }
    }
}
