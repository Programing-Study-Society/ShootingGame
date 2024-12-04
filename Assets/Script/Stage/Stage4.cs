using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage4 : MonoBehaviour
{
    [SerializeField, Header("画面範囲内にエネミーがいるか判定")]
    public StageEnemyCollision enemyCollision;

    [SerializeField, Header("main Camera")]
    public GameObject mainCamera;

    [SerializeField, Header("ポップしたいエネミーを順番に入れる")]
    public List<GameObject> popEnemy;

    [SerializeField, Header("ポップしたいエネミーのポップ数を入れる")]
    public List<int> popEnemyCount;

    [SerializeField, Header("ポップしたいエネミーのポップ数を入れる")]
    public List<Vector3> popEnemyPos;

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

        //stageCountがポップするエネミー数以上なら実行しない
        //Debug.Log(stageCount);
        if(stageCount >= popEnemy.Count)
        {
            return;
        }

        //popCountがpopEnemyCount以下なら実行
        if (popCount < popEnemyCount[stageCount])
        {
            if(stageCount == 0){
                Wave1();
            }
            else if(stageCount == 1){
                Wave2();
            }
            else if(stageCount == 2 || stageCount == 3){
                Wave3();
            }
            else if(stageCount == 4){
                Wave4();
            }
            
            popCount++;
        }
        else
        {
            //エネミーが画面上にいなくなったら実行
            if (!enemyCollision.NonGameObject())
            {
                //Debug.Log(enemyCollision.NonGameObject());
                //popEnemyがstageCount以上なら実行
                if (popEnemy.Count >= stageCount)
                {

                    //stageCountを1増やす
                    stageCount += 1;
                    //stageCountがエネミー数より多ければクリアそうでなければ次のステージ番号表示
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

    public void Wave1(){
        Vector3 pos = popEnemyPos[stageCount];
        pos.y += (popCount) * 3.0f;
        Pop(popEnemy[stageCount],pos);
        pos.x = -pos.x;
        Pop(popEnemy[stageCount],pos);
    }

    public void Wave2(){
        Pop(popEnemy[stageCount], new Vector3(Random.Range(-GlovalValue.xLimit + 1, GlovalValue.xLimit - 1),
                                 Random.Range(0.0f, GlovalValue.yLimit - 1), 0));
    }

    public void Wave3(){
        Pop(popEnemy[stageCount], new Vector3(Random.Range(-GlovalValue.xLimit + 1, GlovalValue.xLimit - 1),
                                 Random.Range(0.0f, GlovalValue.yLimit - 1), 0));
    }

    public void Wave4(){
        Pop(popEnemy[stageCount], popEnemyPos[stageCount]);
    }

    //エネミーポップ関数
    public void Pop(GameObject enemyObject,Vector3 initialPosition)
    {
        //エネミー召喚
        GameObject enemyObj1 = Instantiate(enemyObject);
        initialPosition.y += GlovalValue.yLimit * 2;
        
        //ポジション指定
        enemyObj1.transform.position = initialPosition;
    }
}
