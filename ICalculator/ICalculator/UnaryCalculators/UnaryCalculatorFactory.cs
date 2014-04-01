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
                case "sin(x)":
                    return new Sin();
                case "cos(x)":
                    return new Cos();
                case "tan(x)":
                    return new Tan();
                default:
                    throw new ArgumentException("unknown calculator", "name");
            }
        }
    }
}
