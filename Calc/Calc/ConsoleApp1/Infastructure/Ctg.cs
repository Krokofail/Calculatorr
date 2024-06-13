namespace CalculatorCsharp;

public sealed class Ctg : ICtg
{
    public double Invoke(double num)
    {
        return Math.Cos(num * Math.PI / 180);
    }
}

