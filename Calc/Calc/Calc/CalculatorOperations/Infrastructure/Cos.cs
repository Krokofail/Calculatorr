namespace CalculatorCsharp;

public sealed class Cos : ICos
{
    public double Invoke(double num)
    {
        return Math.Cos(num);
    }
}
