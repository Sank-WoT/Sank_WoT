using System;

namespace ICalculator.SortiOperation
{
    public static class SortingOperationFactory
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
