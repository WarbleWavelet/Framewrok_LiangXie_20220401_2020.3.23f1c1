using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class IOCExample : MonoBehaviour
{
    void Start()
    {

        transform.Find("BtnConnect").GetComponent<Button>().onClick.AddListener(
            () =>{
                Connect();
                transform.Find("ConnectText").GetComponent<TextMeshProUGUI>().text = "连接成功";
            });

    }



    private void Connect()
    {
        // 创建一个 IOC 容器
        var container = new IOCContainer();

        // 注册一个蓝牙管理器的实例
        container.Register(new BluetoothManager());

        // 根据类型获取蓝牙管理器的实例
        var bluetoothManager = container.Get<BluetoothManager>();

        //连接蓝牙
        bluetoothManager.Connect();
    }
}