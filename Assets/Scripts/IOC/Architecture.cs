using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// 对IOC容器的操作
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class Architecture<T> where T : Architecture<T>, new()
{
    #region 类似单例模式 但是仅在内部课访问
    private static T mArchitecture = null;

    // 确保 Container 是有实例的
    static void MakeSureArchitecture()
    {
        if (mArchitecture == null)
        {
            mArchitecture = new T();
            mArchitecture.Init();
        }
    }
    #endregion

    private IOCContainer mContainer = new IOCContainer();

    // 留给子类注册模块
    protected abstract void Init();

    /// <summary>
    /// 增
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="instance"></param>
    public void Register<T>(T instance)
    {
        MakeSureArchitecture();
        mArchitecture.mContainer.Register<T>(instance);
    }

    /// <summary>
    /// 查
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Get<T>() where T : class
    {
        MakeSureArchitecture();
        return mArchitecture.mContainer.Get<T>();
    }
}