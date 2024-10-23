using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPop : MonoBehaviour
{
    public List<GameObject> popEnemy;

    public float lateTime = 1.0f;
    float time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time <= lateTime)
            return;
        Pop(popEnemy[0], new Vector3(0, 0, 0));
        time = 0;

    }

    //ポップしたいオブジェクトと初期位置の値を入力したらポップできる
    public void Pop(GameObject enemyObject,Vector3 initialPosition)
    {
        //エネミーオブジェクト生成
        GameObject enemyObj1 = Instantiate(enemyObject);

        //エネミーオブジェクトの座標設定
        enemyObj1.transform.position = initialPosition;

    }
}
