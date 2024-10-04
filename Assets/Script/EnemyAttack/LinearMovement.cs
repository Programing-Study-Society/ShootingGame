using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement: MonoBehaviour
{
    [SerializeField, Header("??")]
    private float speed;
    [SerializeField, Header("????")]
    private int power;

    private Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        rigid.velocity = transform.up * speed;
    }
}
