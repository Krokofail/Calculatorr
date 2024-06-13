namespace CalculatorCsharp;

public class Application
{
    public Application(
        IMenu<IOperationExecutor<double>> menu)
    {
        this.menu = menu;
    }

    private IMenu<IOperationExecutor<double>> menu;

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            IOperationExecutor<double> operation = menu.Show().ItemSelector.Select();
            Console.Clear();
            Console.WriteLine($"Результат: {operation.Execute()}");
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
