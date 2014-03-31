using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ICalculator.UnaryCalculators
{
    class Napierian_number : IUnaryCalculator
    {
        public string Calculate(double first)
        {
            double result = Math.Pow(Math.E,first );
            return result.ToString();
        }
    }
}
