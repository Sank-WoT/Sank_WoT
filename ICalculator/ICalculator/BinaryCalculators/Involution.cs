using System;

namespace ICalculator.BinaryCalculators
{
    public class Involution : IBinaryCalculator
    {
        public double Calculate(double first, double second)
        {
            double result = Math.Pow(first, second);
            return result;
        }
    }
}
