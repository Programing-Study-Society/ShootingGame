using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2 : MonoBehaviour
{
    [SerializeField, Header("画面範囲内にエネミーがいるか判定")]
    public StageEnemyCollision enemyCollision;

    [SerializeField, Header("main Camera")]
    public GameObject mainCamera;

    [SerializeField, Header("ポップしたいエネミーを順番に入れる")]
    public List<GameObject> popEnemy;

    [SerializeField, Header("ポップしたいエネミーのポップ数を入れる")]
    public List<int> popEnemyCount;

    [SerializeField, Header("ポップしたいエネミーのポジションを入れる")]
    public List<Vector3> popEnemyPos;

    [SerializeField, Header("ポップしたいエネミーを何ウェーブ目に出現させるか入力する")]
    public List<int> popEnemyWave;

    [SerializeField, Header("ポップし終わった後の待ち時間")]
    public float lateTime = 1.0f;

    //ステージが進んだ数
    private int stageCount = 0;

    //待った時間
    private float time = 0.0f;
    //private float bombTime = 0.0f;
    
    //ポップした数
    private int popCount = 0;
    
    private int waveCount = 1;

    void Start()
    {
        Debug.Log("stage:" + waveCount);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //
        time += Time.deltaTime;

        //lateTime以下なら実行しない
        if (time < lateTime)
        {
            return;
        }

        //stageCountがポップするエネミー数以上なら実行しない
        Debug.Log(stageCount);
        if(stageCount >= popEnemy.Count)
        {
            return;
        }

        //popCountがpopEnemyCount以下なら実行
        if (popCount < popEnemyCount[stageCount])
        {
            if(waveCount == 1){
                Wave1();
            }
            else if(waveCount == 2){
                Wave2();
            }
            else if(waveCount == 3){
                Wave3();
            }
            else if(waveCount == 4){
                Wave4();
            }
            else if(waveCount == 5){
                Wave5();
            }
            else if(waveCount == 6){
                Wave6();
            }
            else if(waveCount == 7){
                Wave7();
            }
            popCount++;
        }
        else
        {
            //次のエネミーを連続で出現させたい時実行
            if(stageCount < popEnemyWave.Count - 1){
                if(popEnemyWave[stageCount] == popEnemyWave[stageCount + 1]){
                    stageCount += 1;
                    popCount = 0;
                }
            }
            
            //エネミーが画面上にいなくなったら実行
            if (!enemyCollision.NonGameObject())
            {
                Debug.Log(enemyCollision.NonGameObject());
                //popEnemyがstageCount以上なら実行
                if (popEnemy.Count >= stageCount)
                {

                    //stageCountを1増やす
                    stageCount += 1;
                    //stageCountがエネミー数より多ければクリアそうでなければ次のステージ番号表示
                    if (stageCount >= popEnemy.Count)
                    {
                        //Debug.Log("CLEAR");
                        GlovalValue.stageclear = true;
                    }
                    else
                    {
                        waveCount += 1;
                        //Debug.Log("stage:" + waveCount);
                        popCount = 0;
                    }

                }
            }
        }
        time = 0;
    }

    public void Wave1(){
        Pop(popEnemy[stageCount], popEnemyPos[stageCount]);
    }

    public void Wave2(){
        Pop(popEnemy[stageCount], popEnemyPos[stageCount]);

        //Pop(popEnemy[stageCount], new Vector3(Random.Range(-GlovalValue.xLimit + 0.5f, GlovalValue.xLimit - 0.5f),Random.Range(0.0f, GlovalValue.yLimit - 1), 0));
    }
    public void Wave3(){
        Pop(popEnemy[stageCount], popEnemyPos[stageCount]);
        //Pop(popEnemy[stageCount], new Vector3(Random.Range(-GlovalValue.xLimit + 0.5f, GlovalValue.xLimit - 0.5f),Random.Range(0.0f, GlovalValue.yLimit - 1), 0));
    }
    public void Wave4(){
        Vector3 pos = popEnemyPos[stageCount];
        pos.y -= (popCount) * 3.0f;
        Pop(popEnemy[stageCount],pos);
        pos.x = -pos.x;
        Pop(popEnemy[stageCount],pos);
    }

    public void Wave5(){
        Pop(popEnemy[stageCount], popEnemyPos[stageCount]);
    }

    public void Wave6(){
        Pop(popEnemy[stageCount], new Vector3(Random.Range(-GlovalValue.xLimit + 1, GlovalValue.xLimit - 1),
                                 Random.Range(0.0f, GlovalValue.yLimit - 1), 0));
        lateTime = 3.0f;
    }

    bool boss = true; //Wave7で2体敵を出すため
    public void Wave7(){
        if (boss == true)
        {
            lateTime = 3.5f;
            Pop(popEnemy[stageCount], popEnemyPos[stageCount]);
            boss = false;
        }
        else
        {
            lateTime = 5.0f;
            Pop(popEnemy[stageCount], new Vector3(Random.Range(-GlovalValue.xLimit + 1, GlovalValue.xLimit - 1),
                                 Random.Range(0.0f, GlovalValue.yLimit - 1), 0));
        }
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