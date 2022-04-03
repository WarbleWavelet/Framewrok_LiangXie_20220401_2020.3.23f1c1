using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class CounterModel
{
    private static int mCount = 0;

    public static Action<int> OnCountChanged;

    public static int Count
    {
        get => mCount;
        set
        {
            if (value != mCount)
            {
                mCount = value;
                OnCountChanged?.Invoke(value);
            }
        }
    }
}