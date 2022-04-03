using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class CounterModel
{
    public static BindableProperty<int> Count = new BindableProperty<int>()
    {
        Value = 0
    };
}