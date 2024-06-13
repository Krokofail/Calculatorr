namespace CalculatorCsharp;

public sealed class LogicOr : ILogicOr
{
    public double Invoke(int num1, int num2)
    {
        return num1 | num2;
    }
}