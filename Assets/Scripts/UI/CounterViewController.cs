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
        transform.Find("BtnAdd").GetComponent<Button>()
            .onClick.AddListener(() =>
            {
                // 交互逻辑
                CounterModel.Count++;

                // 表现逻辑
                UpdateView();
            });

        transform.Find("BtnSub").GetComponent<Button>()
            .onClick.AddListener(() =>
            {
                // 交互逻辑
                CounterModel.Count--;

                // 表现逻辑
                UpdateView();
            });

        // 表现逻辑
        UpdateView();
    }

    void UpdateView()
    {
        transform.Find("CountText").GetComponent<TextMeshProUGUI>().text = CounterModel.Count.ToString();
    }
}
