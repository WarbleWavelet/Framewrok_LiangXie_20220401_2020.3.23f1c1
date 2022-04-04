using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public struct KillEnemyCommand : ICommand
{
    public void Execute()
    {
        var gameModel = PointGame.Get<GameModel>();
        gameModel.KillCount.Value++;

        if (gameModel.KillCount.Value >=9)
        {
            GamePassEvent.Trigger();
        }
    }
}