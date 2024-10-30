using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySlanting : MonoBehaviour
{
    private float MoveSpeed = 3.0f;
    private Vector3 firstPos;

    void Start()
    {
        firstPos = this.transform.position;
    }
    
    void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * MoveSpeed + firstPos.x, transform.position.y, transform.position.z);
        transform.position = new Vector3(transform.position.x,Mathf.Sin(Time.time) + firstPos.y,transform.position.z);
    }
}
