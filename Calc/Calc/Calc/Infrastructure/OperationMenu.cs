namespace CalculatorCsharp;

public sealed class OperationMenu : IMenu<IOperationExecutor<double>>
{
    public OperationMenu(IOperationProvider operationProvider,
        IMenuItemSelector<IOperationExecutor<double>> menuItemSelector)
    {
        this.operationProvider = operationProvider;
        ItemSelector = menuItemSelector;
    }

    private readonly IOperationProvider operationProvider;

    public IMenuItemSelector<IOperationExecutor<double>> ItemSelector { get; }

    public IMenu<IOperationExecutor<double>> Show()
    {
        Console.WriteLine("======== КАЛЬКУЛЯТОР ==========");
        int i = 1;
        foreach (IOperation operation in operationProvider.Get())
            Console.WriteLine($"{i++}. ОПЕРАЦИЯ {operation.Name};");
        return this;
    }
}
