namespace CalculatorCsharp;

public sealed class SubstractionOperation : DoubleMathOperation
{
    public SubstractionOperation(
        ISubstraction executor,
        IOperationArgsProvider<TwoStandartArgs> args)
        : base("Вычитание")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly ISubstraction executor;
    private readonly IOperationArgsProvider<TwoStandartArgs> args;

    public override double Execute()
    {
        TwoStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number1, args.Number2);
    }
}
