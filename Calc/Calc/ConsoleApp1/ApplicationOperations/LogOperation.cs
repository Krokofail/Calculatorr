namespace CalculatorCsharp;

public sealed class LogOperation : DoubleMathOperation
{
    public LogOperation(
        ILog executor,
        IOperationArgsProvider<LogArgs> args)
        : base("Логарифм")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly ILog executor;
    private readonly IOperationArgsProvider<LogArgs> args;

    public override double Execute()
    {
        LogArgs args = this.args.Get();
        return executor.Invoke(args.Number1, args.Number2);
    }
}
