namespace ICalculator.BinaryCalculators
{
    public class Divider : IBinaryCalculator
    {
        public double Calculate(double first, double second)
        {
            double result = first / second;
            return result;
        }
    }
}
