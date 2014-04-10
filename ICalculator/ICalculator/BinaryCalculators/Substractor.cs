namespace ICalculator.BinaryCalculators
{
    public class Substractor : IBinaryCalculator
    {
       public double Calculate(double first, double second)
       {
           double result = first - second;
           return result;
       }
    }
}
