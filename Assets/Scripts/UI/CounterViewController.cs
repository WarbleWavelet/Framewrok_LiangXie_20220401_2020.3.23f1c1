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
        OnCountChangedEvent.Register(OnCountChanged);
        //
        transform.Find("BtnAdd").GetComponent<Button>()
            .onClick.AddListener(() =>
            {
                // 交互逻辑
                CounterModel.Count++;

                // 表现逻辑
            });

        transform.Find("BtnSub").GetComponent<Button>()
            .onClick.AddListener(() =>
            {
                // 交互逻辑
                CounterModel.Count--;

                // 表现逻辑
            });

        // 表现逻辑
        OnCountChanged();
    }

    // 表现逻辑
    private void OnCountChanged()
    { 
        transform.Find("CountText").GetComponent<TextMeshProUGUI>().text = CounterModel.Count.ToString();
    }

    private void OnDestroy()
    {
        OnCountChangedEvent.UnRegister(OnCountChanged);
    }
}
