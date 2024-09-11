using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySlanting : MonoBehaviour
{
    private float MoveSpeed = 3.0f;
    
    void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * MoveSpeed, 0, 0);
        transform.position = new Vector3(transform.position.x,Mathf.Sin(Time.time),transform.position.z);
    }
}
