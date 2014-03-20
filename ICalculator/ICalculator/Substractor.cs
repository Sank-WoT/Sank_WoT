using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator
{
   public class Substractor
    {
       public string Calculate(double first, double second)
       {
           double result = first - second;
           return result.ToString();
       }
    }
}
