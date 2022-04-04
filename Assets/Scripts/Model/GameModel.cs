using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class GameModel
{
    public  BindableProperty<int> KillCount = new BindableProperty<int>()
    {
        Value = 0
    };

    public  BindableProperty<int> Gold = new BindableProperty<int>()
    {
        Value = 0
    };

    public  BindableProperty<int> Score = new BindableProperty<int>()
    {
        Value = 0
    };

    public  BindableProperty<int> BestScore = new BindableProperty<int>()
    {
        Value = 0
    };
}
