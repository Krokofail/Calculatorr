namespace CalculatorCsharp;

public sealed class LogicAndOperation : DoubleMathOperation
{
    public LogicAndOperation(
        ILogicAnd executor,
        IOperationArgsProvider<LogicArgs> args)
        : base("Логическое И")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly ILogicAnd executor;
    private readonly IOperationArgsProvider<LogicArgs> args;

    public override double Execute()
    {
        LogicArgs args = this.args.Get();
        return executor.Invoke(args.Number1, args.Number2);
    }
}
