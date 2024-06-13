namespace CalculatorCsharp;

public sealed class OperationMenuItemSelector : IMenuItemSelector<IOperationExecutor<double>>
{
    public OperationMenuItemSelector(
        IMenuItemSelectorProvider selector,
        IOperationProvider operationProvider)
    {
        this.selector = selector;
        this.operationProvider = operationProvider;
    }

    private readonly IMenuItemSelectorProvider selector;
    private readonly IOperationProvider operationProvider;

    public IOperationExecutor<double> Select()
    {
        int id = selector.GetMenuItemId();
        return operationProvider.Get().ElementAt(id - 1);
    }
}
