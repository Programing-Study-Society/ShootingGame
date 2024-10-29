using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftClickAttack : MonoBehaviour
{
    [SerializeField, Header("弾オブジェクト")]
    private GameObject Attack;

    [SerializeField, Header("弾を発射する時間")]
    private float shootTime = 0.5f;

    private float shootCount;

    //強化されているかどうか判別する変数
    public bool attackStrengthening = false;

    //
    private float attackInterval = 1.0f;

    //攻撃オブジェクト生成用オブジェクト
    private GameObject atkObj1;
    private GameObject atkObj2;
    private GameObject atkObj3;

    // Start is called before the first frame update
    void Start()
    {
        shootCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        AttackControl();
    }

    private void AttackControl()
    {
        // 左クリックされたとき実行
        if (Input.GetMouseButton(0))
        {
            //shootTime以上になったら実行
            shootCount += Time.deltaTime;
            if (shootCount < shootTime) return;

            //攻撃オブジェクト生成
            atkObj1 = Instantiate(Attack, transform.position, transform.rotation);

            //強化されていた場合+2
            if (attackStrengthening)
            {
                atkObj2 = Instantiate(Attack, transform.position, transform.rotation);
                atkObj3 = Instantiate(Attack, transform.position, transform.rotation);
            }

            //攻撃オブジェクト生成初期位置値
            atkObj1.transform.position = transform.position +
                new Vector3(0f, transform.lossyScale.y / 2.0f, 0f);


            //Debug.Log(atkObj1.transform.position);
            if (attackStrengthening)
            {
                atkObj2.transform.position = transform.position +
                new Vector3(0f + attackInterval, (transform.lossyScale.y / 2.0f), 0f);

                atkObj3.transform.position = transform.position +
                    new Vector3(0f - attackInterval, (transform.lossyScale.y / 2.0f), 0f);

                /*atkObj2.transform.rotation = Quaternion.Euler(transform.rotation.x,
                    transform.rotation.y,
                    transform.rotation.z - 15);
                atkObj3.transform.rotation = Quaternion.Euler(transform.rotation.x,
                    transform.rotation.y,
                    transform.rotation.z + 15);*/
            }

            //時間初期化
            shootCount = 0f;
        }
    }
}
