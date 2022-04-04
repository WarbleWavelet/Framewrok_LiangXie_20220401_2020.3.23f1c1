using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public  class CounterModel:Singleton<CounterModel>
{
    // ��Ҫ����һ���� Public ����
    private CounterModel() { }


    public  BindableProperty<int> Count = new BindableProperty<int>()
    {
        Value = 0
    };
}