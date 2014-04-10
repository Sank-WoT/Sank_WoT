namespace ICalculator.BinaryCalculators
{
    public class Additor : IBinaryCalculator
    {
        public double Calculate(double first, double second)
        {
            double result = first + second;
            return result;
        }

    }
}
