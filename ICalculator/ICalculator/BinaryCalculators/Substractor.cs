namespace ICalculator.BinaryCalculators
{
    public class Substractor : IBinaryCalculator
    {
       public string Calculate(double first, double second)
       {
           double result = first - second;
           return result.ToString();
       }
    }
}
