using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//敵のHP管理
public class EnemyManager : MonoBehaviour
 {
    int hp = 100;  

    public void Damege(int damage)
    {
        hp -= damage;
        Debug.Log("敵のHP" + hp);
    }
}
