using System;

namespace ICalculator.UnaryCalculators
{
  public  class Arcsin : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            if (first < -1|| first > 1)
            {
                throw new Exception("Аргумент арксинуса должен лежать в пределах от -1 до 1 ");
            }
            double result = Math.Asin(first);
            return result;
        }
    }
}
