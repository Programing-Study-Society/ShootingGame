using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCameraFollow : MonoBehaviour
{
    public MovingCamera movingCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.0f, movingCamera.cameraDistance, 0.0f);
        //Debug.Log(transform.position);
    }
}
