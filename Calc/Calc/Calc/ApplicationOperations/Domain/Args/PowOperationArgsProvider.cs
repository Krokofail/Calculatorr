namespace CalculatorCsharp;

public sealed class PowOperationArgsProvider : IOperationArgsProvider<PowArgs>
{
    public PowArgs Get()
    {
        Console.Write("Введите число возводимое в степень: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите число степени: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        return new() { 
            Number = num1, 
            Power = num2
        };
    }
}
