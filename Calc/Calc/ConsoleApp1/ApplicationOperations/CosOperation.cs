namespace CalculatorCsharp;

public sealed class CosOperation : DoubleMathOperation
{
    public CosOperation(
        ICos executor,
        IOperationArgsProvider<OneStandartArgs> args)
        : base("Косинус")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly ICos executor;
    private readonly IOperationArgsProvider<OneStandartArgs> args;

    public override double Execute()
    {
        OneStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number);
    }
}
