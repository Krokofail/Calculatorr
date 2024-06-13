namespace CalculatorCsharp;

public sealed class Sin : ISin
{
    public double Invoke(double num)
    {
        return Math.Sin(num);
    }
}
