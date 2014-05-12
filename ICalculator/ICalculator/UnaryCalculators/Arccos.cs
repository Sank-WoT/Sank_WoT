using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator.UnaryCalculators
{
    public class Arccos : IUnaryCalculator
    {
        public double Calculate(double first)
        {
            if (first > 1 || first < 0)
            {
                throw new Exception("Аргумент аркосинуса должен лежать в пределах от 0 до 1 ");
            }
            double result = Math.Acos(first);
            return result;
        }
    }
}
