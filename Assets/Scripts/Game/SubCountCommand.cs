public struct SubCountCommand : ICommand
{
    public void Execute()
    {
        CounterModel.Count.Value--;
    }
}