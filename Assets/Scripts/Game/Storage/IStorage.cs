// 1. 设计模块接口
public interface IStorage
{
    void SaveString(string key, string value);
    string LoadString(string key, string defaultValue = "");
}