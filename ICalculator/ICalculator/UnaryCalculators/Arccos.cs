using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator.UnaryCalculators
{
    public class Arccos : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            double result = Math.Acos(first);
            return result;
        }
    }
}
