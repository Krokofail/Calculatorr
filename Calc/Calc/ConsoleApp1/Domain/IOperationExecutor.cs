namespace CalculatorCsharp;

public interface IOperationExecutor<TResult> : IOperation
{
    TResult Execute();
}
