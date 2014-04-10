using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator.UnaryCalculators
{
  public  class Ln : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            double result = Math.Log(first, Math.E);
            return result;
        }
    }
}
