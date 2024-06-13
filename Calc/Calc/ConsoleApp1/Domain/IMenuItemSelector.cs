namespace CalculatorCsharp;

public interface IMenuItemSelector<out T> where T : IOperationExecutor<double>
{
    public T Select();
}
