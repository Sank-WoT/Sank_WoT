using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator.UnaryCalculators
{
    public class Tan : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            double result = Math.Tan(first);
            return result;
        }
    }
}
