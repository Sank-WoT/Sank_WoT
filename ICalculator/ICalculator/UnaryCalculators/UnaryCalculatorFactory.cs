﻿using System;

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
                    return new NapierianNumber();
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
                case "cot(x)":
                    return new Cot();
                case "ln(x)":
                    return new Ln();
                default:
                    throw new ArgumentException("unknown calculator", "name");
            }
        }
    }
}
