using System;

namespace ICalculator.UnaryCalculators
{
    public class Sin : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            double result = Math.Sin(first);
            return result;
        }
    }
}
