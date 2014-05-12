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
            if (first <=0 )
            {
                throw new Exception(" Число должно бцыть больше нуля ");
            }
            double result = Math.Log(first, Math.E);
            return result;
        }
    }
}
