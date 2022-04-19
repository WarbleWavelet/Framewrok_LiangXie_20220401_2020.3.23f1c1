/// <summary>
/// DIP
/// </summary>

public class CounterModel : ICounterModel
{
    public BindableProperty<int> Count { get; } = new BindableProperty<int>()
    {
        Value = 0
    };
}