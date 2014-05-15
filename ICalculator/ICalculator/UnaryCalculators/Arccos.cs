using System;

namespace ICalculator.UnaryCalculators
{
    public class Arccos : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            if (first  < -1 || first > 1  )
            {
                throw new Exception("Аргумент аркосинуса должен лежать в пределах от -1 до 1 ");
            }
            double result = Math.Acos(first);
            return result;
        }
    }
}
