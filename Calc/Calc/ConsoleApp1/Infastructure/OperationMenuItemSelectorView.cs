namespace CalculatorCsharp;

    public class OperationMenuItemSelectorView : IMenuItemSelectorProvider
    {
        public int GetMenuItemId()
        {
            while (true)
            {
                try
                {
                    Console.Write("Выберите действие: ");
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введено некорректное значение. Пожалуйста, введите целое число.");
                }
            }
        }
    }
