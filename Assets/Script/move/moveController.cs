using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveController : MonoBehaviour
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
        if (Input.GetKey(KeyCode.RightArrow))
        {// �E�����̈ړ�����
            Vector2 pos = transform.position;
            pos.x += speed;
            transform.position = pos;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {// �������̈ړ�����
            Vector2 pos = transform.position;
            pos.x -= speed;
            transform.position = pos;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {// ������̈ړ�����
            Vector2 pos = transform.position;
            pos.y += speed;
            transform.position = pos;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {// �������̈ړ�����
            Vector2 pos = transform.position;
            pos.y -= speed;
            transform.position = pos;
        }
    }
}
