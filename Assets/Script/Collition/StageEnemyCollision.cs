using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageEnemyCollision : MonoBehaviour
{
    bool isEnemyEnter, isEnemyStay, isEnemyExit;
    
    string ENEMY_TAG = "Enemy";

    [HideInInspector]
    public GameObject CollisionObject;

    public List<GameObject> colList = new List<GameObject> ();

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

    public bool NonGameObject(){
        for(int i = 0; i < colList.Count;i++){
            if(colList[i]  != null){
                return true;
            }
        }
        colList.Clear();
        return false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ENEMY_TAG)
        {
            colList.Add (collision.gameObject);
            //Debug.Log("enemy = " + colList.Count);
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
