namespace CalculatorCsharp;

public sealed class LogStandartOperationArgsProvider : IOperationArgsProvider<LogArgs>
{
    public LogArgs Get()
    {
        int num1, num2;
        while (true)
        {
            try
            {
                Console.Write("Введите степень логарифма: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите основание логарифма: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
            }
        }

        return new LogArgs
        {
            Number1 = num1,
            Number2 = num2
        };
    }
}