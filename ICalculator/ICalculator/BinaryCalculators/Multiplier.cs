namespace ICalculator.BinaryCalculators
{
    public class Multiplier : IBinaryCalculator
    {
        public string Calculate(double first, double second)
        {
            double result = first * second;
            return result.ToString();
        }
    }
}
