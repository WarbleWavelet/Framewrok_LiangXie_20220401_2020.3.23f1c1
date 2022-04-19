public class PointGame : Architecture<PointGame>
{
    // 这里注册模块
    protected override void Init()
    {
        Register< IGameModel > (new GameModel());
    }
}