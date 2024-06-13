namespace CalculatorCsharp;

public sealed class SinOperation : DoubleMathOperation
{
    public SinOperation(
        ISin executor,
        IOperationArgsProvider<OneStandartArgs> args)
        : base("Синус")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly ISin executor;
    private readonly IOperationArgsProvider<OneStandartArgs> args;

    public override double Execute()
    {
        OneStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number);
    }
}
