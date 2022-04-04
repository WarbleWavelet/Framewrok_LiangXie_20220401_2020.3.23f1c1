using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
 

public class CounterViewController : MonoBehaviour
{
    private CounterModel mCounterModel;

    void Start()
    {
        // 获取
        mCounterModel = CounterApp.Get<CounterModel>();
        // 注册
        mCounterModel.Count.OnValueChanged += OnCountChanged;
        //
        transform.Find("BtnAdd").GetComponent<Button>()
            .onClick.AddListener(() =>
            {
                new AddCountCommand()
                    .Execute();
            });

        transform.Find("BtnSub").GetComponent<Button>()
            .onClick.AddListener(() =>
            {
                new SubCountCommand()
                    .Execute();
            });

        // 表现逻辑
        OnCountChanged(mCounterModel.Count.Value);
    }

    // 表现逻辑
    private void OnCountChanged(int newValue)
    { 
        transform.Find("CountText").GetComponent<TextMeshProUGUI>().text = newValue.ToString();
    }

    private void OnDestroy()
    {
        // 注册
        mCounterModel.Count.OnValueChanged -= OnCountChanged;
    }
}
