using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using Random = UnityEngine.Random;


/// <summary>
/// 提高对静态类识别度<para />
/// 增加访问限制<para />
/// </summary>
/// <typeparam name="T"></typeparam>
public class Singleton<T> where T : class
{
    public static T Instance
    {
        get
        {
            if (mInstance == null)
            {
                // 通过反射获取构造
                var ctors = typeof(T).GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);
                // 获取无参非 public 的构造
                var ctor = Array.Find(ctors, c => c.GetParameters().Length == 0);

                if (ctor == null)
                {
                    throw new Exception("Non-Public Constructor() not found in " + typeof(T));
                }

                mInstance = ctor.Invoke(null) as T;
            }

            return mInstance;
        }
    }

    private static T mInstance;
}