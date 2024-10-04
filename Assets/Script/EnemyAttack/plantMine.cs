using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantMine : MonoBehaviour
{
    [SerializeField, Header("地雷オブジェクト")]
    private GameObject attack1;
    [SerializeField, Header("地雷を置く時間")]
    private float shootTime;

    private float shootCount;

    // Start is called before the first frame update
    void Start()
    {
        shootCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        shooting();
    }

    private void shooting()
    {
        //shootTimeの値分待たないと実行しない
        shootCount += Time.deltaTime;
        if (shootCount < shootTime) return;

        //アタックオブジェクト生成
        GameObject atkObj1 = Instantiate(attack1);

        //アタックオブジェクトの座標設定
        atkObj1.transform.position = transform.position +
            new Vector3(0f, transform.lossyScale.y / 2.0f, 0f);
        
        //カウントを初期化する
        shootCount = 0f;
    }
}
