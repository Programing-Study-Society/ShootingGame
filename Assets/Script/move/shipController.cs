using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipController : MonoBehaviour
{
    public float speed;
    public Camera m_camera;
    // Start is called before the first frame update
    void Start()
    {
        m_camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var worldPoint = m_camera.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(worldPoint);
        worldPoint.z = 0f;
        transform.up = Vector3.MoveTowards(
            transform.up,
            worldPoint - transform.position,
            10f * Time.deltaTime);
    }
}
