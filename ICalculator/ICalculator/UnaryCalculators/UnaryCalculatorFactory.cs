using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator.UnaryCalculators
{
    public static class UnaryCalculatorsFactory
    {
        public static IUnaryCalculator CreateBinaryCalculator(string name)
        {
            switch (name)
            {
                case "sqrt":
                    return new Sqrt();
                case "e^x":
                    return new Napierian_number();
                case "arcsin(x)":
                    return new Arcsin();
                default:
                    throw new ArgumentException("unknown calculator", "name");
            }
        }
    }
}
