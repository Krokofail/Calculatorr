namespace CalculatorCsharp;

public struct PowArgs
{
    public double Number { get; set; }
    public double Power { get; set; }

    public PowArgs(double num1, double num2)
    {
        Number = num1;
        Power = num2;
    }
}
