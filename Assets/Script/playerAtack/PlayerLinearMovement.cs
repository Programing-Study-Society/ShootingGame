using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLinearMovement: MonoBehaviour
{
    [SerializeField, Header("速さ")]
    private float speed;
    [SerializeField, Header("ダメージ")]
    private int power;

    public EnemyCollision enemyCollision;

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
        Attack();
    }

    private void Move()
    {
        rigid.velocity = transform.up * speed;
    }

    private void Attack(){
        if(enemyCollision.IsEnemy()){
            EnemyStatas enemyStatas = enemyCollision.CollisionObject.GetComponent<EnemyStatas>();
            enemyStatas.HP -= power;
            Destroy(this.gameObject);
        }
    }
}