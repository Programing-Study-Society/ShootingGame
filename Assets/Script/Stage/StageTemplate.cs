using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTemplate : MonoBehaviour
{
    [SerializeField, Header("エネミーが指定範囲内にいるか確認するスクリプト")]
    public EnemyCollision enemyCollision;

    [SerializeField, Header("main Camera")]
    public GameObject mainCamera;

    [SerializeField, Header("popしたいエネミーを順番に入れるリスト")]
    public List<GameObject> popEnemy;

    [SerializeField, Header("エネミーポップ間の待ち時間")]
    public float lateTime = 1.0f;

    //ステージ進行状況
    private int stageCount = 0;

    //何秒経ったかを保存する変数
    private float time = 0.0f;
    
    //何体ポップしたかを保存する変数
    private int popCount = 0;

    void Start()
    {
        Debug.Log("stage:" + (stageCount + 1));
    }

    // Update is called once per frame
    void Update()
    {
        //エネミーをポップして何秒経ったかを計測
        time += Time.deltaTime;

        //lateTime以上になったら実行
        if (time > lateTime)
        {
            //popCount数ポップしたら実行せず else へ
            if (popCount < 10)
            {
                Pop(popEnemy[stageCount], new Vector3(Random.Range(-GlovalValue.xLimit, GlovalValue.xLimit),
                                     Random.Range(0.0f, GlovalValue.yLimit), 0));
                popCount++;
            }
            else
            {
                //エネミーがいなくなったら実行
                if (!enemyCollision.IsEnemy())
                {
                    //popEnemyのリスト数以上になったら実行しない
                    if (popEnemy.Count - 1 > stageCount)
                    {
                        //次のエネミーをポップできるようにする
                        stageCount += 1;
                        Debug.Log("stage:" + (stageCount + 1));
                        popCount = 0;
                    }
                }
            }
            time = 0;
        }
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
