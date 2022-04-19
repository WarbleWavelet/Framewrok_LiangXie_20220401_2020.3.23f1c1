using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CounterApp : Architecture<CounterApp>
{
    protected override void Init()
    {
        Register<ICounterModel>(new CounterModel());
    }
}