using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstMovement : MonoBehaviour
{
    public float speed = 0.1f;

    [HideInInspector]
    public bool firstMove = true;

    private Vector3 firstPos;
    private float MoveRange;
    // Start is called before the first frame update
    void Start()
    {
        firstPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveRange < GlovalValue.yLimit * 2)
        {
            this.transform.position -= new Vector3(0.0f, speed, 0.0f);
            MoveRange += speed;
        }
        else
        {
            firstMove = false;
        }
    }
}
