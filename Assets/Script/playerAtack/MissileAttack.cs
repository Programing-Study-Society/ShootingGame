using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileAttack : MonoBehaviour
{
    [SerializeField, Header("速さ")]private float speed;

    [SerializeField, Header("ダメージ")]private float power;
    
    [SerializeField, Header("爆発エフェクト")]public GameObject explotionEffect;

    [SerializeField, Header("ミサイルコリジョン")]public EnemyCollision enemyCollision;

    [SerializeField, Header("PlayerStatas")]public PlayerStatas playerStatas;

    [HideInInspector]public GameObject SearchObject;

    [HideInInspector]public int searchEnemyNumber = -1;

    [HideInInspector]private float actualTime = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Attack();
    }

    private void Move()
    {
        //プレイヤーを追撃
        if (SearchObject != null){
            transform.position = Vector2.MoveTowards(transform.position,new Vector2(SearchObject.transform.position.x, SearchObject.transform.position.y),speed * Time.deltaTime);
        }
        else{
            if(actualTime <= 0){
                Destroy(this.gameObject);
                GameObject effect = Instantiate(explotionEffect, transform.position, Quaternion.identity);
                Destroy(effect, 0.5f);
            }else{
                actualTime -= Time.deltaTime;
            }
        }
    }

    private void Attack(){
        if(enemyCollision.IsEnemy()){
            if (enemyCollision.CollisionObject != null){
                EnemyStatas enemyStatas = enemyCollision.CollisionObject.GetComponent<EnemyStatas>();
                enemyStatas.HP -= power + power * (float)(playerStatas.ATK * GlovalValue.attackMag);
                Destroy(this.gameObject);
                GameObject effect = Instantiate(explotionEffect, transform.position, Quaternion.identity);
                Destroy(effect, 0.5f);
            }
        }
    } 
}
