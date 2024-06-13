

namespace CalculatorCsharp;

public sealed class AdditionOperation : DoubleMathOperation
{
    public AdditionOperation(
        IAddition executor,
        IOperationArgsProvider<TwoStandartArgs> args)
        : base("Сложение")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly IAddition executor;
    private readonly IOperationArgsProvider<TwoStandartArgs> args;

    public override double Execute()
    {
        TwoStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number1, args.Number2);
    }
}
