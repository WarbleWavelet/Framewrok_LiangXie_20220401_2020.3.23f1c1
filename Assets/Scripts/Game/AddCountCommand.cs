public struct AddCountCommand : ICommand
{
    public void Execute()
    {
        CounterModel.Count.Value++;
    }
}