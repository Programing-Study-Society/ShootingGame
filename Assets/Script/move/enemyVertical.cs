using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyVertical : MonoBehaviour
{
    private float MoveSpeed = 3.0f;
    
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x,Mathf.Sin(Time.time),transform.position.z);
    }
}
