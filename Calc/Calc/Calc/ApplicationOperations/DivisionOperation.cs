namespace CalculatorCsharp;

public sealed class DivisionOperation : DoubleMathOperation
{
    public DivisionOperation(
        IDivision executor,
        IOperationArgsProvider<TwoStandartArgs> args)
        : base("Деление")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly IDivision executor;
    private readonly IOperationArgsProvider<TwoStandartArgs> args;

    public override double Execute()
    {
        TwoStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number1, args.Number2);
    }
}
