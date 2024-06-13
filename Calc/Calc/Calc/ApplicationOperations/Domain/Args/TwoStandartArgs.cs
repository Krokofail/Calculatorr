namespace CalculatorCsharp;

public struct TwoStandartArgs(double num1, double num2)
{
    public required double Number1 { get; set; } = num1;
    public required double Number2 { get; set; } = num2;
}
