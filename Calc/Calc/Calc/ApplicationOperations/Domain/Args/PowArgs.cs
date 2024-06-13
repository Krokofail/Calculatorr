namespace CalculatorCsharp;

public struct PowArgs(double num1, double num2)
{
    public required double Number { get; set; } = num1;
    public required double Power { get; set; } = num2;
}
