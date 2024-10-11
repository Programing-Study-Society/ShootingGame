using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    bool isEnemyEnter, isEnemyStay, isEnemyExit;
    
    string ENEMY_TAG = "Enemy";

    public GameObject CollisionObject;

    public bool IsEnemy()
    {
        bool isEnemy = false;
        if (isEnemyEnter || isEnemyStay)
        {
            isEnemy = true;
        }
        else if (isEnemyExit)
        {
            isEnemy = false;
        }

        isEnemyEnter = false;
        isEnemyStay = false;
        isEnemyExit = false;
        return isEnemy;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ENEMY_TAG)
        {
            isEnemyEnter = true;
            CollisionObject = collision.gameObject;
            //Debug.Log("プレイヤーが判定に入りました");
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == ENEMY_TAG)
        {
            isEnemyStay = true;
            //Debug.Log("プレイヤーが判定に入り続けています"); 
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == ENEMY_TAG)
        {
            isEnemyExit = true;
            isEnemyStay = false;
            isEnemyEnter = false;
            //Debug.Log("プレイヤーが判定をでました");
        }

    }
}
