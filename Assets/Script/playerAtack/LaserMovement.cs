using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    [SerializeField, Header("速さ")]
    private float speed;

    [SerializeField, Header("ダメージ")]
    private float power;

    public EnemyCollision enemyCollision;

    private Rigidbody2D rigid;
    private Vector3 thisScale;

    private float actualTime = 0.0f;

    private float lateTime = 0.4f;
    private float time = 0.2f;

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
        thisScale.y += speed / 30;
        this.transform.localScale = thisScale;
        if(actualTime >= 1.0f){
            Destroy(this.gameObject);
        }else{
            actualTime += Time.deltaTime;
        }
        
    }

    private void Attack(){
        if(enemyCollision.IsEnemy()){
            for(int i = 0; i < enemyCollision.colList.Count ; i++){
                if (enemyCollision.colList[i] != null){
                    EnemyStatas enemyStatas = enemyCollision.colList[i].GetComponent<EnemyStatas>();
                    enemyStatas.HP -= power + power * (float)(GlovalValue.attack * GlovalValue.attackMag);
                    time = 0.0f;
                    //Debug.Log(enemyStatas.HP);
                }
            }
            //Debug.Log("当たった"); 
        }
        
    } 
}
