public interface IGameModel
{
    BindableProperty<int> KillCount { get; }
    BindableProperty<int> Gold { get; }
    BindableProperty<int> Score { get; }
    BindableProperty<int> BestScore { get; }
}