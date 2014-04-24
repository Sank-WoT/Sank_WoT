using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalculator.SortiOperation
{
    public class SortiOperationFactoryc
    {
        public static ISortiOperation CreateSortiOperation(string name)
        {
            switch (name)
            {
                case ">":
                    return new Ascending();
                case "<":
                    return new Descending();
                default:
                    throw new ArgumentException("unknown calculator", "name");
            }
        }
    }
}
