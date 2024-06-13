namespace CalculatorCsharp;

public sealed class Division : IDivision
{
    public double Invoke(double num1, double num2)
    {
        if (num2 == 0) 
            throw new DivideByZeroException();
        return num1 / num2;
    }
}
