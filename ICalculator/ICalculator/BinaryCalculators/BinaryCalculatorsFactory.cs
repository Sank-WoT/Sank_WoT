using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator.BinaryCalculators
{
    public static class BinaryCalculatorsFactory
    {
        public static IBinaryCalculator CreateBinaryCalculator(string name)
        {
            switch (name)
            {
                case "+":
                    return new Additor();
                case "-":
                    return  new Substractor();
                case "*":
                    return new Multiplier();
                case "/":
                    return new Divider();
                case "^":
                    return  new Involution();
                default:
                    throw new ArgumentException("unknown calculator","name");
            }
        }
    }
}
