using System;

namespace ICalculator.UnaryCalculators
{
    public class Tan : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            double result = Math.Tan(first);
            return result;
        }
    }
}
