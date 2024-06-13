namespace CalculatorCsharp;

public sealed class OperationProvider : IOperationProvider
{
    private IEnumerable<IOperationExecutor<double>> operations;

    public OperationProvider(IEnumerable<IOperationExecutor<double>> operations)
    {
        this.operations = operations;
    }

    public IEnumerable<IOperationExecutor<double>> Get()
    {
        return operations;
    }
}
