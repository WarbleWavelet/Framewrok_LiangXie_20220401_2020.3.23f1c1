using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public  class CounterModel:Singleton<CounterModel>
{
    // 需要声明一个非 Public 构造
    private CounterModel() { }


    public  BindableProperty<int> Count = new BindableProperty<int>()
    {
        Value = 0
    };
}