namespace CalculatorCsharp;
public sealed class OneStandartOperationArgsProvider : IOperationArgsProvider<OneStandartArgs> 
{ public OneStandartArgs Get() 
{ while (true)
{ try 
{ Console.Write("Введите число: "); double number = Convert.ToDouble(Console.ReadLine()); return new OneStandartArgs
{ Number = number };
} catch (FormatException)
{ Console.WriteLine("Ошибка ввода. Пожалуйста, введите число.");
            }
        }
    }
} 