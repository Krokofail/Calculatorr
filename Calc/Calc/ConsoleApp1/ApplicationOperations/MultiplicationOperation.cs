namespace CalculatorCsharp;

public sealed class MultiplicationOperation : DoubleMathOperation
{
    public MultiplicationOperation(
        IMultiplication executor,
        IOperationArgsProvider<TwoStandartArgs> args)
        : base("Умножение")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly IMultiplication executor;
    private readonly IOperationArgsProvider<TwoStandartArgs> args;

    public override double Execute()
    {
        TwoStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number1, args.Number2);
    }
}
