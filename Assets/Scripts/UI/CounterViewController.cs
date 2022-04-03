using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
 

public class CounterViewController : MonoBehaviour
{
    void Start()
    {
        // 注册
        CounterModel.Count.OnValueChanged += OnCountChanged;
        //
        transform.Find("BtnAdd").GetComponent<Button>()
            .onClick.AddListener(() =>
            {
                // 交互逻辑
                CounterModel.Count.Value++;

                // 表现逻辑
            });

        transform.Find("BtnSub").GetComponent<Button>()
            .onClick.AddListener(() =>
            {
                // 交互逻辑
                CounterModel.Count.Value--;

                // 表现逻辑
            });

        // 表现逻辑
        OnCountChanged(CounterModel.Count.Value);
    }

    // 表现逻辑
    private void OnCountChanged(int newValue)
    { 
        transform.Find("CountText").GetComponent<TextMeshProUGUI>().text = newValue.ToString();
    }

    private void OnDestroy()
    {
        // 注册
        CounterModel.Count.OnValueChanged -= OnCountChanged;
    }
}
