using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySide : MonoBehaviour
{
    private float MoveSpeed = 3.0f;
    
    void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * MoveSpeed, transform.position.y, transform.position.z);
        Debug.Log(Mathf.Sin(Time.time) * MoveSpeed);
    }
}
