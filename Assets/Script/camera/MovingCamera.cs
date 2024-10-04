using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    public Transform cameraTrans;
    public float cameraDistance;
    Vector3 cameraPos;
    // Start is called before the first frame update
    void Start()
    {
        cameraPos = cameraTrans.position;
    }

    // Update is called once per frame
    void Update()
    {
        cameraPos.y += cameraDistance;
        cameraTrans.position = cameraPos;
        //Debug.Log(cameraTrans.position);
    }
}
