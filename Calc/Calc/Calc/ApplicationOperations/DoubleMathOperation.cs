namespace CalculatorCsharp;

public abstract class DoubleMathOperation : IOperationExecutor<double>
{
    protected DoubleMathOperation(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public abstract double Execute();
}
