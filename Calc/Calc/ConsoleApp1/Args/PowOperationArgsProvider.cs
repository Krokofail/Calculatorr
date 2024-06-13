namespace CalculatorCsharp;

    public sealed class PowOperationArgsProvider : IOperationArgsProvider<PowArgs>
    {
        public PowArgs Get()
        {
            double num1 = 0; double num2 = 0; bool validInput = false;
            do
            {
                try
                {
                    Console.Write("Введите число возводимое в степень: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
                }
            } while (!validInput);

            validInput = false;

            do
            {
                try
                {
                    Console.Write("Введите число степени: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
                }
            } while (!validInput);

            return new PowArgs
            {
                Number = num1,
                Power = num2
            };
        }
    }

