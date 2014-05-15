using System;

namespace ICalculator.UnaryCalculators
{
  public  class Ln : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            if (first <=0 )
            {
                throw new Exception(" Для вычисления число под логарифмом  должно быть больше нуля ");
            }
            double result = Math.Log(first, Math.E);
            return result;
        }
    }
}
