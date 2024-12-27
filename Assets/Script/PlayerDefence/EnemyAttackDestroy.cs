using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackDestroy : MonoBehaviour
{
    public EnemyAttackCollision enemyAttackCollision;

    private float actualTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        
        if(actualTime <= (GlovalValue.barrierTime * 0.1) + 0.1){
            actualTime += Time.deltaTime;
        }else{
            Destroy(this.gameObject);
        }
        
    }
}
