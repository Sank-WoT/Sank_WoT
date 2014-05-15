using System;

namespace ICalculator.UnaryCalculators
{
    public class Log : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            if (first <= 0 )
            {
                throw new Exception("Значение логарифма должно быть > 0");
            }
            double result = Math.Log(first,2);
            return result;
        }
    }
}
