namespace CalculatorCsharp;

public sealed class TwoStandartOperationArgsProvider : IOperationArgsProvider<TwoStandartArgs>
{
    public TwoStandartArgs Get()
    {
        Console.Write("Введите 1-е число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите 2-е число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        return new() { 
            Number1 = num1, 
            Number2 = num2
        };
    }
}
