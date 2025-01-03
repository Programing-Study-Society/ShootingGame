using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeWayAttack : MonoBehaviour
{
    [SerializeField, Header("playerオブジェクト")]
    private GameObject player;
    [SerializeField, Header("弾オブジェクト")]
    private GameObject attack1;
    [SerializeField, Header("弾を発射する時間")]
    private float shootTime;

    private float shootCount;

    private float attackInterval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        shootCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("player");
        shooting();
    }

    //3方向攻撃
    private void shooting()
    {
        //shootTimeの値分待たないと実行しない
        shootCount += Time.deltaTime;
        if (shootCount < shootTime) return;

        //アタックオブジェクト生成
        GameObject atkObj1 = Instantiate(attack1);
        GameObject atkObj2 = Instantiate(attack1);
        GameObject atkObj3 = Instantiate(attack1);

        //アタックオブジェクトの座標設定
        atkObj1.transform.position = transform.position + 
            new Vector3(0f,transform.lossyScale.y / 2.0f,0f);
        atkObj2.transform.position = transform.position +
            new Vector3(0f + attackInterval, transform.lossyScale.y / 2.0f, 0f);
        atkObj3.transform.position = transform.position +
            new Vector3(0f - attackInterval, transform.lossyScale.y / 2.0f, 0f);

        //プレイヤーの座標からエネミーの座標を引いてその間のベクトルを計算
        Vector3 dir1 = player.transform.position - transform.position;
        Vector3 dir2 = player.transform.position - transform.position;
        Vector3 dir3 = player.transform.position - transform.position;
        
        //オブジェクトの向きをdirのベクトルの方向に変更
        atkObj1.transform.rotation = Quaternion.FromToRotation(transform.up, dir1);
        atkObj2.transform.rotation = Quaternion.FromToRotation(transform.up, dir2);
        atkObj3.transform.rotation = Quaternion.FromToRotation(transform.up, dir3);

        //カウントを初期化する
        shootCount = 0f;
    }

    private float randomF()
    {
        float dir = Random.Range(-1.0f, 1.0f);

        return dir;
    } 
}
