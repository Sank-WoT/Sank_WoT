using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ICalculator.UnaryCalculators
{
    public class Napierian_number : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            double result = Math.Pow(Math.E,first );
            return result;
        }
    }
}
