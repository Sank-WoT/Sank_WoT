using System;

namespace ICalculator.UnaryCalculators
{
    public class Cos : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            double result = Math.Cos(first);
            return result;
        }
    }
}
