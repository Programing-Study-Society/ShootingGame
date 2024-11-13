using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySlanting : MonoBehaviour
{
    private FirstMovement firstMovement;
    private float startTime;
    private float MoveSpeed = 3.0f;
    private Vector3 firstPos;

    void Start()
    {
        firstPos = this.transform.position - new Vector3(0.0f,GlovalValue.yLimit * 2,0.0f);
        //Debug.Log("enemySlanting;" + firstPos);
        firstMovement = this.gameObject.GetComponent<FirstMovement>();
    }
    
    void FixedUpdate()
    {
        if(firstMovement.firstMove){
            startTime = Time.time;
            return;
        } 
        transform.position = new Vector3(Mathf.Sin(startTime-Time.time) * MoveSpeed + firstPos.x, transform.position.y, transform.position.z);
        transform.position = new Vector3(transform.position.x,Mathf.Sin(startTime-Time.time) + firstPos.y,transform.position.z);
    }
}
