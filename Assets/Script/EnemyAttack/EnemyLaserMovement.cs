using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserMovement : MonoBehaviour
{
    [SerializeField, Header("速さ")]
    private float speed;

    [SerializeField, Header("ダメージ")]
    private int power;

    private Rigidbody2D rigid;
    private Vector3 thisScale;

    private float actualTime = 0.0f;
    public PlayerCollision playerCollision;

    // Start is called before the first frame update
    void Start()
    {

        rigid = GetComponent<Rigidbody2D>();
        thisScale = this.transform.localScale;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        Attack();
    }

    private void Move()
    {
        rigid.velocity = transform.up * speed;
        thisScale.y += speed / 40;
        this.transform.localScale = thisScale;
        if(actualTime >= 1.0f){
            Destroy(this.gameObject);
        }else{
            actualTime += Time.deltaTime;
        }
        
    }

    private void Attack(){
        if(playerCollision.IsPlayer()){
            GlovalValue.HP -= power;
            Destroy(this.gameObject);
            //Debug.Log(GlovalValue.HP);
        }
    }
}
