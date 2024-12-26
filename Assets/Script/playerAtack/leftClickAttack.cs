using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftClickAttack : MonoBehaviour
{
    [SerializeField, Header("弾オブジェクト")]
    private GameObject Attack;

    [SerializeField, Header("弾を発射する時間")]
    private float shootTime = 0.5f;
    private float stragTime = 10.0f;

    private float shootCount;
    private float StrengtheningshootCount;

    private float strengTimeCount;

    //強化されているかどうか判別する変数
    public bool attackStrengthening = false;

    //攻撃オブジェクト生成用オブジェクト
    private GameObject atkObj1;
    private int attackCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        shootCount = 0.0f;
        StrengtheningshootCount = 0.0f;
        strengTimeCount = 0.0f;
        attackCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(attackStrengthening){
            if(strengTimeCount >= stragTime){
                attackStrengthening = false;
                strengTimeCount = 0.0f;
            }else{
                strengTimeCount += Time.deltaTime;
            }
        }
        if(GlovalValue.pauseFlag){
            return;
        }
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
            if(attackStrengthening){
                StrengtheningshootCount += Time.deltaTime;
                if (StrengtheningshootCount < 0.05 && attackCount != 0) return;
                AttackInstant();
                StrengtheningshootCount = 0;
                if(attackCount < 3){
                    attackCount++;
                    return;
                }
            }
            else{
                AttackInstant();
            }

            //時間初期化
            shootCount = 0f;
            attackCount = 1;
        }
    }

    private void AttackInstant(){
         //攻撃オブジェクト生成
        atkObj1 = Instantiate(Attack, transform.position, transform.rotation);
        //攻撃オブジェクト生成初期位置値
        atkObj1.transform.position = transform.position +
            new Vector3(0f, transform.lossyScale.y / 2.0f, 0f);
    }
}
