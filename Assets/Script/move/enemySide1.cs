using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySide1 : MonoBehaviour
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
        //Debug.Log(Mathf.Sin(Time.time) * MoveSpeed);
    }
}
