﻿using System;
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
                default:
                    throw new ArgumentException("unknown calculator", "name");
            }
        }
    }
}
