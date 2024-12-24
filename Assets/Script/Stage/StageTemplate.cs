using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTemplate : MonoBehaviour
{
    [SerializeField, Header("画面範囲内にエネミーがいるか判定")]
    public StageEnemyCollision enemyCollision;

    [SerializeField, Header("main Camera")]
    public GameObject mainCamera;

    [SerializeField, Header("ポップしたいエネミーを順番に入れる")]
    public List<GameObject> popEnemy;

    [SerializeField, Header("ポップしたいエネミーのポップ数を入れる")]
    public List<int> popEnemyCount;

    [SerializeField, Header("ポップし終わった後の待ち時間")]
    public float lateTime = 1.0f;

    //ステージが進んだ数
    private int stageCount = 0;

    //待った時間
    private float time = 0.0f;
    
    //ポップした数
    private int popCount = 0;

    void Start()
    {
        Debug.Log("stage:" + (stageCount + 1));
    }

    // Update is called once per frame
    void Update()
    {
        //
        time += Time.deltaTime;

        //lateTime以下なら実行しない
        if (time < lateTime)
        {
            return;
        }

        //popCount???|?b?v????????s???? else ??
        //Debug.Log(stageCount);
        if(stageCount >= popEnemy.Count)
        {
            return;
        }
        if (popCount < popEnemyCount[stageCount])
        {
            Pop(popEnemy[stageCount], new Vector3(Random.Range(-GlovalValue.xLimit + 1, GlovalValue.xLimit - 1),
                                 Random.Range(0.0f, GlovalValue.yLimit - 1), 0));
            popCount++;
        }
        else
        {
            //?G?l?~?[????????????????s
            if (!enemyCollision.IsEnemy())
            {
                //popEnemy????X?g??????????????s?????
                if (popEnemy.Count >= stageCount)
                {

                    //????G?l?~?[???|?b?v???????????
                    stageCount += 1;
                    //?|?b?v??????????????I??
                    if (stageCount >= popEnemy.Count)
                    {
                        Debug.Log("CLEAR");
                    }
                    else
                    {
                        Debug.Log("stage:" + (stageCount + 1));
                        popCount = 0;
                    }

                }
            }
        }
        time = 0;
    }

    //?|?b?v???????I?u?W?F?N?g???????u??l??????????|?b?v?????
    public void Pop(GameObject enemyObject,Vector3 initialPosition)
    {
        //?G?l?~?[?I?u?W?F?N?g????
        GameObject enemyObj1 = Instantiate(enemyObject);
        initialPosition.y += GlovalValue.yLimit * 2;
        //?G?l?~?[?I?u?W?F?N?g????W???
        enemyObj1.transform.position = initialPosition;

    }
}
