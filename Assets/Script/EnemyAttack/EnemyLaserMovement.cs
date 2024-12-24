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

    private float actualTime = 2.0f;

    private float lateTime = 1.0f;
    private float time = 0.7f;
    public PlayerCollision playerCollision;

    // Start is called before the first frame update
    void Start()
    {

        rigid = GetComponent<Rigidbody2D>();
        thisScale = this.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        time += Time.deltaTime;

        //lateTime以下なら実行しない
        if (time < lateTime)
        {
            return;
        }
        Attack();
    }

    private void Move()
    {
        rigid.velocity = transform.up * speed;
        thisScale.y += speed / 100;
        this.transform.localScale = thisScale;
        if(actualTime <= 0){
            Destroy(this.gameObject);
        }else{
            actualTime -= Time.deltaTime;
        }
        
    }

    private void Attack(){
        if(playerCollision.IsPlayer()){
            GlovalValue.HP -= power;
            time = 0.0f;
            //Debug.Log(GlovalValue.HP);
        }
    }
}
