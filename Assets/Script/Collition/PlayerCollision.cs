using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    bool isPlayerEnter, isPlayerStay, isPlayerExit;
    
    string PLAYER_TAG = "Player";

    public bool IsPlayer()
    {
        bool isPlayer = false;
        if (isPlayerEnter || isPlayerStay)
        {
            isPlayer = true;
        }
        else if (isPlayerExit)
        {
            isPlayer = false;
        }

        isPlayerEnter = false;
        isPlayerStay = false;
        isPlayerExit = false;
        return isPlayer;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == PLAYER_TAG)
        {
            isPlayerEnter = true;
            //Debug.Log("プレイヤーが判定に入りました");
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == PLAYER_TAG)
        {
            isPlayerStay = true;
            //Debug.Log("プレイヤーが判定に入り続けています"); 
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == PLAYER_TAG)
        {
            isPlayerExit = true;
            isPlayerStay = false;
            isPlayerEnter = false;
            //Debug.Log("プレイヤーが判定をでました");
        }

    }
}
