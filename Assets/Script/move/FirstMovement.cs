using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstMovement : MonoBehaviour
{
    private float speed = 0.05f;

    [HideInInspector]
    public bool firstMove = true;

    private Vector3 firstPos;
    private float MoveRange;
    // Start is called before the first frame update
    void Start()
    {
        firstPos = this.transform.position + new Vector3(0.0f,GlovalValue.yLimit * 2,0.0f);
        firstMove = true;
        MoveRange = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveRange < GlovalValue.yLimit * 2 - speed)
        {
            this.transform.position -= new Vector3(0.0f, speed, 0.0f);
            MoveRange += speed;
            //Debug.Log(this.transform.position);
        }
        else
        {
            firstMove = false;
        }
    }
}
