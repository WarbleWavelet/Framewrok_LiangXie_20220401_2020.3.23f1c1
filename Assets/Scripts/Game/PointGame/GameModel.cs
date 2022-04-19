using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class GameModel:IGameModel
{
    public BindableProperty<int> KillCount { get; } = new BindableProperty<int>()
    {
        Value = 0
    };

    public BindableProperty<int> Gold { get; } = new BindableProperty<int>()
    {
        Value = 0
    };

    public BindableProperty<int> Score { get; } = new BindableProperty<int>()
    {
        Value = 0
    };

    public BindableProperty<int> BestScore { get; } = new BindableProperty<int>()
    {
        Value = 0
    };
}
