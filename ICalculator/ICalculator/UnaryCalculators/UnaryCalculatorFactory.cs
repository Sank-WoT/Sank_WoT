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
                case "arccos(x)":
                    return new Arccos();
                case "log2(x)":
                    return new Log();
                case "arctg(x)":
                    return new Arctg();
                default:
                    throw new ArgumentException("unknown calculator", "name");
            }
        }
    }
}
