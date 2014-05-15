using System;

namespace ICalculator.UnaryCalculators
{
    public class Cot : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            double result =1f / Math.Tan(first);
            return result;
        }
    }
}
