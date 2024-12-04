using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    [SerializeField, Header("速さ")]
    private float speed;

    [SerializeField, Header("ダメージ")]
    private int power;

    public EnemyCollision enemyCollision;

    private Rigidbody2D rigid;
    private Vector3 thisScale;

    private float actualTime = 2.0f;

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
        if(enemyCollision.IsEnemy()){
            for(int i = 0; i < enemyCollision.colList.Count ; i++){
                if (enemyCollision.colList[i] != null){
                    EnemyStatas enemyStatas = enemyCollision.colList[i].GetComponent<EnemyStatas>();
                    enemyStatas.HP -= power * GlovalValue.attack;
                
                }
            } 
        }
        
    } 
}
