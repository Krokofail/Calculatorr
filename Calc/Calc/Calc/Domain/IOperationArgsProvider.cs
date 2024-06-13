namespace CalculatorCsharp;

public interface IOperationArgsProvider<TArgs> where TArgs : struct
{
    TArgs Get();
}
