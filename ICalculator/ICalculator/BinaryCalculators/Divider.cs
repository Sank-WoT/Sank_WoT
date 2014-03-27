namespace ICalculator.BinaryCalculators
{
    public class Divider : IBinaryCalculator
    {
        public string Calculate(double first, double second)
        {
            double result = first / second;
            return result.ToString();
        }
    }
}
