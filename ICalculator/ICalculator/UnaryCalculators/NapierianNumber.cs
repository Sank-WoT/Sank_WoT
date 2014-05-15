using System;

namespace ICalculator.UnaryCalculators
{
    public class NapierianNumber : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            double result = Math.Pow(Math.E,first );
            return result;
        }
    }
}
