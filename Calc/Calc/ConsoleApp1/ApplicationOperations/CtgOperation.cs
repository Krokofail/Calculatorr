namespace CalculatorCsharp;

public sealed class CtgOperation : DoubleMathOperation
{
    public CtgOperation(
        ICtg executor,
        IOperationArgsProvider<OneStandartArgs> args)
        : base("Котангенс")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly ICtg executor;
    private readonly IOperationArgsProvider<OneStandartArgs> args;

    public override double Execute()
    {
        OneStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number);
    }
}