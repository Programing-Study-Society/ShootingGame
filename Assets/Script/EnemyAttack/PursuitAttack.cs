
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PursuitAttack: MonoBehaviour
{
    [SerializeField, Header("playerオブジェクト")]
    private GameObject player;
    [SerializeField, Header("弾オブジェクト")]
    private GameObject attack1;
    [SerializeField, Header("弾を発射する時間")]
    private float shootTime;

    private float shootCount;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        shootCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        shooting();
    }

    //追尾攻撃
    private void shooting()
    {
        //shootTimeの値分待たないと実行しない
        shootCount += Time.deltaTime;
        if (shootCount < shootTime) return;

        //アタックオブジェクト生成
        GameObject atkObj1 = Instantiate(attack1);

        //アタックオブジェクトの座標設定
        atkObj1.transform.position = transform.position + 
            new Vector3(0f,transform.lossyScale.y / 2.0f,0f);

        //プレイヤーの座標とエネミーの座標との間のベクトル計算
        Vector3 dir = player.transform.position - transform.position;

        //オブジェクトの向きをdirのベクトルの方向に変更
        atkObj1.transform.rotation = Quaternion.FromToRotation(transform.up, dir);

        //カウントを初期化する
        shootCount = 0f;
    }
}
