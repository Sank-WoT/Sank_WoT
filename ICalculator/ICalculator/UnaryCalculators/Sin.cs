using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator.UnaryCalculators
{
    class Sin: IUnaryCalculator
    {
        public string Calculate(double first)
        {
            double result = Math.Sin(first);
            return result.ToString();
        }
    }
}
