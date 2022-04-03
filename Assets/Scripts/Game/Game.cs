using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
 

public class Game : MonoBehaviour
{
    #region 字段
    GameObject enemies;
    public   int curCount=0;
    public  int totalCount=0;


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
        totalCount = enemies.transform.childCount;
        for (int i = 0; i < totalCount; i++)
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
        totalCount--;
        if (totalCount <= 0)
            UI._instance.PassGame();
    }

    public void PlayGame()
    { 
        enemies.gameObject.SetActive(true);
    }
    #endregion

}
