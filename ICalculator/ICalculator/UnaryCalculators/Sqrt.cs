using System;

namespace ICalculator.UnaryCalculators
{
    public class Sqrt : IUnaryCalculator
    {

        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new Exception(" Число под корнем должно быть положительным ");
            }
            double result = Math.Pow(first, 0.5);
            return result;
        }
    }
}
