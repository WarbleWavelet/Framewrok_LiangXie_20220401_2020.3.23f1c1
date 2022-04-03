using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
 

public class Game : MonoBehaviour
{
    #region 字段
    GameObject enemies;



    public static Game _instance;

    void Awake()
    {
        _instance = this;
    }




    #endregion

    #region 生命
    void Start()
    {
        enemies=transform.Find("Enemies").gameObject;

        for (int i = 0; i < 9; i++)
        {
            enemies.transform.GetChild(i).gameObject.AddComponent<Enemy>();
        }
        //
        enemies.gameObject.SetActive(false);
        //
        GameStartEvent.Register(OnGameStart);
        GameModel.KillCount.OnValueChanged += OnEnemyKilled;
    }




    private void OnDestroy()
    {
        GameStartEvent.UnRegister(OnGameStart);
        GameModel.KillCount.OnValueChanged -= OnEnemyKilled;
    }
    #endregion

    #region 辅助

    private void OnEnemyKilled(int killedCount)
    {

        // 十个全部消灭再显示通关界面
        if (killedCount >= 9)
        {
            new PassGameCommand()
                .Execute();
        }
    }
    

    public void OnGameStart()
    { 
        enemies.gameObject.SetActive(true);
    }
    #endregion

}
