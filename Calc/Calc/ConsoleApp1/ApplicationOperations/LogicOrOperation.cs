namespace CalculatorCsharp;

public sealed class LogicOrOperation : DoubleMathOperation
{
    public LogicOrOperation(
        ILogicOr executor,
        IOperationArgsProvider<LogicArgs> args)
        : base("Логическое ИЛИ")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly ILogicOr executor;
    private readonly IOperationArgsProvider<LogicArgs> args;

    public override double Execute()
    {
        LogicArgs args = this.args.Get();
        return executor.Invoke(args.Number1, args.Number2);
    }
}
