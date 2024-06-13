namespace CalculatorCsharp;

    public sealed class TwoStandartOperationArgsProvider : IOperationArgsProvider<TwoStandartArgs>
    {
        public TwoStandartArgs Get()
        {
            double num1 = ReadNumber("Введите 1-е число: ");
            double num2 = ReadNumber("Введите 2-е число: ");
            return new TwoStandartArgs
            {
                Number1 = num1,
                Number2 = num2
            };
        }

        private double ReadNumber(string message)
        {
            double number;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                try
                {
                    number = Convert.ToDouble(input);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
                }
            }
            return number;
        }
    }
