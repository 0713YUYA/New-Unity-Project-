using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour 
{
    int atk = 10;
    private void OnTriggerEnter2D(Collider2D collision) //敵に当たった処理
    {
        if (collision.gameObject.tag == "Enemy")　//当たったモノが敵だったら
        {
            EnemyManager enemy = collision.gameObject.GetComponent<EnemyManager>();
            enemy.Damege(atk);
        }

    }

}
