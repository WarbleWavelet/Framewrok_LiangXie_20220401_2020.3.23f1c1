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
    }




    private void OnDestroy()
    {
    }
    #endregion

    #region 辅助
    internal void KillOneEnemy()
    {
        GameModel.KillCount++;
        if (GameModel.KillCount >= 9)
            UI._instance.PassGame();
    }

    public void PlayGame()
    { 
        enemies.gameObject.SetActive(true);
    }
    #endregion

}
