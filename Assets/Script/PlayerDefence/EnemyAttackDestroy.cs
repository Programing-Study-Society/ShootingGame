using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackDestroy : MonoBehaviour
{
    public EnemyAttackCollision enemyAttackCollision;

    private float actualTime = 0.1f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        
        if(actualTime <= 0){
            Destroy(this.gameObject);
        }else{
            actualTime -= Time.deltaTime;
        }
        
    }
}
