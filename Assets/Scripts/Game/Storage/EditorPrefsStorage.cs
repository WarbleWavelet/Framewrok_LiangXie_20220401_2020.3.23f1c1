// 3. 实现接口
// 编辑器存储
using UnityEditor;

public class EditorPrefsStorage : IStorage
{
    public void SaveString(string key, string value)
    {
#if UNITY_EDITOR
        EditorPrefs.SetString(key, value);
#endif
    }

    public string LoadString(string key, string defaultValue = "")
    {
#if UNITY_EDITOR
        return EditorPrefs.GetString(key, defaultValue);
#else
                return ""
#endif
    }
}