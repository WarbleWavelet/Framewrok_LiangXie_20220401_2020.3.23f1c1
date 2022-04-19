using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
 

public  class UI : MonoBehaviour
{
    #region 字段

    public  Button startButton;
    public GameObject gamePanel;
    public GameObject startPanel;
    public GameObject winPanel;
    public GameObject counterPanel;
    public GameObject IOCPanel;
    public GameObject storagePanel;


    public static UI _instance;

    void Awake()
    {
        _instance = this;
    }


    #endregion

    #region 生命
    void Start()
    {
        Transform canvas = transform.Find("Canvas");
        gamePanel = canvas.transform.Find("GamePanel").gameObject;
        startPanel = canvas.transform.Find("StartPanel").gameObject;
        winPanel = canvas.transform.Find("WinPanel").gameObject;
        counterPanel = canvas.transform.Find("CounterPanel").gameObject;
        IOCPanel = canvas.transform.Find("BluetoothPanel").gameObject;
        storagePanel = canvas.transform.Find("StoragePanel").gameObject;
        //
        startButton = startPanel.transform.Find("StartButton").GetComponent<Button>();
        
        //
        counterPanel.AddComponent<CounterViewController>();
        IOCPanel.AddComponent<IOCExample>();
        storagePanel.AddComponent<DIPExample>();

        //
        gamePanel.SetActive(false);
        startButton.onClick.AddListener(PlayGame);
        //
        GamePassEvent.Register(PassGame);
    }
    private void OnDestroy()
    {
        GamePassEvent.UnRegister(PassGame);
    }
    #endregion


    #region 辅助
    private void PlayGame()
    {
        startPanel.SetActive(false);
        gamePanel.SetActive(true);
        new StartGameCommand()
            .Execute();

    }
    public  void PassGame()
    {
        gamePanel.SetActive(false);
        winPanel.SetActive(true);

    }
    #endregion
}
