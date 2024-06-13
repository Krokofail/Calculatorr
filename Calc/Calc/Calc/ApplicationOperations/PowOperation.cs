namespace CalculatorCsharp;

public sealed class PowOperation : DoubleMathOperation
{
    public PowOperation(
        IPow executor,
        IOperationArgsProvider<PowArgs> args)
        : base("Возведение в степень")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly IPow executor;
    private readonly IOperationArgsProvider<PowArgs> args;

    public override double Execute()
    {
        PowArgs args = this.args.Get();
        return executor.Invoke(args.Number, args.Power);
    }
}
