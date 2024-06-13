
namespace CalculatorCsharp;

public sealed class Log : ILog
{
    public double Invoke(double num, double power)
    {
        return Math.Log(num, power);
    } 
}

