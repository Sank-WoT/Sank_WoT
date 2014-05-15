using System;

namespace ICalculator.UnaryCalculators
{
    public class Arctg : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            double result = Math.Atan(first);
            return result;
        }
    }
}
