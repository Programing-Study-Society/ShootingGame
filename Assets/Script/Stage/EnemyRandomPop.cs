using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomPop : MonoBehaviour
{
    public GameObject mainCamera;
    public List<GameObject> popEnemy;

    public float lateTime = 1.0f;
    float time = 0.0f;

    int popCount = 0;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (popCount > 10)
        {
            if (time <= lateTime * 10)
                return;
            popCount = 0;
        }
        else
        {
            if (time <= lateTime)
                return;
        }
        Pop(popEnemy[Random.Range(0, popEnemy.Count)], new Vector3(Random.Range(-GlovalValue.xLimit, GlovalValue.xLimit), 
                                     Random.Range(0.0f, GlovalValue.yLimit), 0));
        time = 0;
        popCount++;

    }

    //ポップしたいオブジェクトと初期位置の値を入力したらポップできる
    public void Pop(GameObject enemyObject,Vector3 initialPosition)
    {
        //エネミーオブジェクト生成
        GameObject enemyObj1 = Instantiate(enemyObject);
        initialPosition.y += GlovalValue.yLimit * 2;
        //エネミーオブジェクトの座標設定
        enemyObj1.transform.position = initialPosition;

    }
}
