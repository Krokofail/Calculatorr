namespace CalculatorCsharp;

public interface IMenu<out T> where T : IOperationExecutor<double>
{
    public IMenu<T> Show();
    public IMenuItemSelector<T> ItemSelector { get; }
}
