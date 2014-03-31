using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator.UnaryCalculators
{
    internal class Log : IUnaryCalculator
    {
        public string Calculate(double first)
        {
            double result = Math.Log(first,2);
            return result.ToString();
        }
    }
}
