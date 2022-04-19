using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class DIPExample : MonoBehaviour
{
    IOCContainer container;
    IStorage storage;
    // 4. 使用
    private void Start()
    {
        // 创建一个 IOC 容器
         container = new IOCContainer();
        //
        string type = transform.Find("Dropdown").GetComponent<Dropdown>().captionText.text;
        print(type);
        transform.Find("ResText").GetComponent<TextMeshProUGUI>().text =type;
        ;
        transform.Find("ResText").GetComponent<TextMeshProUGUI>().text=SGByType(type);


    }

  public  string SaveString(StorageType type= StorageType.PlayerPrefsStorage, string key="name",string value="运行时存储")
    {
        Init(type);
        storage.SaveString(key,value);
        
        return storage.LoadString(key);

    }

  public  string GetString(StorageType type, string key="name")
    {
        Init(type);
        return storage.LoadString(key);
    }

    void Init(StorageType type)
    {
        if (type == StorageType.PlayerPrefsStorage)
        {
            container.Register<IStorage>(new PlayerPrefsStorage());
        }
        else
        {
            container.Register<IStorage>(new EditorPrefsStorage());
        }
        storage = container.Get<IStorage>();


    }

    string  SGByType(string str)
    {
        StorageType type = StorageType.PlayerPrefsStorage;
        if (str == "PlayerPrefsStorage")
        {
             type = StorageType.PlayerPrefsStorage;
        }
        else
        {
             type = StorageType.EditorPrefsStorage;
        }

        string value = "NULL";
        transform.Find("BtnSave").GetComponent<Button>().onClick.AddListener(
            () => {
              value  =GetComponent<DIPExample>().SaveString(type);
            });

        transform.Find("BtnLoad").GetComponent<Button>().onClick.AddListener(
            () => {
             value =  GetComponent<DIPExample>().GetString(type,"name") + "保存成功";
            });

        print(value);
        return  value;
    }
}
