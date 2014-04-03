﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator.UnaryCalculators
{
    class Ln : IUnaryCalculator
    {
        public string Calculate(double first)
        {
            double result = Math.Log(first, Math.E);
            return result.ToString();
        }
    }
}