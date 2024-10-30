using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandamAttack : MonoBehaviour
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
            new Vector3(0f, transform.lossyScale.y / 2.0f, 0f);
        atkObj3.transform.position = transform.position +
            new Vector3(0f, transform.lossyScale.y / 2.0f, 0f);

        //プレイヤーの座標からエネミーの座標を引いてその間のベクトルを計算
        Vector3 dir1 = new Vector3(randomF(), randomF(), 0.0f);
        Vector3 dir2 = new Vector3(randomF(), randomF(), 0.0f);
        Vector3 dir3 = new Vector3(randomF(), randomF(), 0.0f);
        
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
