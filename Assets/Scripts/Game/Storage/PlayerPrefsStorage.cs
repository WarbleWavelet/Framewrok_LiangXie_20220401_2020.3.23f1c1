// 2. 实现接口
// 运行时存储
using UnityEngine;

public class PlayerPrefsStorage : IStorage
{
    public void SaveString(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
    }

    public string LoadString(string key, string defaultValue = "")
    {
        return PlayerPrefs.GetString(key, defaultValue);
    }
}