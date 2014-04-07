using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator.UnaryCalculators
{
  public  class Arcsin: IUnaryCalculator
    {
        public string Calculate(double first)
        {
            double result = Math.Asin(first);
            return result.ToString();
        }
    }
}
