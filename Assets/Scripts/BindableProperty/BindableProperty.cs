using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
 
/// <summary>
/// ����������HP����ȥ�ص���Slider��
/// </summary>
/// <typeparam name="T"></typeparam>
public class BindableProperty<T> where T : IEquatable<T>
{
    private T mValue;

    public T Value
    {
        get => mValue;
        set
        {
            if (!mValue.Equals(value))
            {
                mValue = value;
                OnValueChanged?.Invoke(value);
            }
        }
    }

    public Action<T> OnValueChanged;
}
