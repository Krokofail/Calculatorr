namespace CalculatorCsharp;

    public sealed class LogicStandartOperationArgsProvider : IOperationArgsProvider<LogicArgs>
    {
        public LogicArgs Get()
        {
            int num1, num2;
            while (true)
            {
                try
                {
                    Console.Write("Введите первое число для логической операции: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите второе число для логической операции: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
                }
            }

            return new LogicArgs
            {
                Number1 = num1,
                Number2 = num2
            };
        }
    }
