using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BluetoothManager:IBluetoothManager
{
    public void Connect()
    {
        Debug.Log("蓝牙连接成功");
    }
}