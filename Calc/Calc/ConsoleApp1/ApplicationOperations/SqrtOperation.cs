namespace CalculatorCsharp;

public sealed class SqrtOperation : DoubleMathOperation
{
    public SqrtOperation(
        ISqrt executor,
        IOperationArgsProvider<OneStandartArgs> args)
        : base("Квадратный корень")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly ISqrt executor;
    private readonly IOperationArgsProvider<OneStandartArgs> args;

    public override double Execute()
    {
        OneStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number);
    }
}
