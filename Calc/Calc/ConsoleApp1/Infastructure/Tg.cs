namespace CalculatorCsharp;

public sealed class Tg : ITg
{
    public double Invoke(double num)
    {
        return Math.Tan(num);
    }
}

