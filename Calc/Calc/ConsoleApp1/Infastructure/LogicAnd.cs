namespace CalculatorCsharp;

public sealed class LogicAnd : ILogicAnd
{
    public double Invoke(int num1, int num2)
    {
        return num1 & num2;
    }
}