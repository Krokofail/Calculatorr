namespace CalculatorCsharp;

public sealed class OneStandartOperationArgsProvider : IOperationArgsProvider<OneStandartArgs>
{
    public OneStandartArgs Get()
    {
        Console.Write("Введите число: ");
        return new() { 
            Number = Convert.ToDouble(Console.ReadLine()), 
        };
    }
}