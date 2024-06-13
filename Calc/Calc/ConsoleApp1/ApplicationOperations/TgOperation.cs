namespace CalculatorCsharp;

public sealed class TgOperation : DoubleMathOperation
{
    public TgOperation(
        ITg executor,
        IOperationArgsProvider<OneStandartArgs> args)
        : base("Тангенс")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly ITg executor;
    private readonly IOperationArgsProvider<OneStandartArgs> args;

    public override double Execute()
    {
        OneStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number);
    }
}