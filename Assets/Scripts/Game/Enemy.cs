using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
 

public class Enemy : MonoBehaviour
{
    #region 系统
    private void OnMouseDown()
    {

        Destroy(gameObject);

        new KillEnemyCommand()
            .Execute();

    }
    #endregion 

}
