using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator.UnaryCalculators
{
    public class Cot : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            double result =1f / Math.Tan(first);
            return result;
        }
    }
}
