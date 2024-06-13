namespace CalculatorCsharp;

public interface IOperationProvider
{
    public IEnumerable<IOperationExecutor<double>> Get();
}
