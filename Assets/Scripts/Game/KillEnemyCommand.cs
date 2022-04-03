using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public struct KillEnemyCommand : ICommand
{
    public void Execute()
    {
        GameModel.KillCount.Value++;
    }
}