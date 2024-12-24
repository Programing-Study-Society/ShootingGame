using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool isEnter, isStay, isExit;
    
    public string OBJECT_TAG;
    public GameObject CollitionObject;

    public bool IsObject()
    {
        bool isObject = false;
        if (isEnter || isStay)
        {
            isObject = true;
        }
        else if (isExit)
        {
            isObject = false;
        }

        isEnter = false;
        isStay = false;
        isExit = false;
        return isObject;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == OBJECT_TAG)
        {
            isEnter = true;
            CollitionObject = collision.gameObject;
            //Debug.Log("プレイヤーが判定に入りました");
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == OBJECT_TAG)
        {
            isStay = true;
            //Debug.Log("プレイヤーが判定に入り続けています"); 
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == OBJECT_TAG)
        {
            isExit = true;
            isStay = false;
            isEnter = false;
            //Debug.Log("プレイヤーが判定をでました");
        }

    }
}
