using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPpanel : MonoBehaviour
{
    //　ライフゲージプレハブ
    [SerializeField]
    private GameObject lifeObj;

    //　ライフゲージ全削除＆HP分作成
    public void SetLifeGauge() {
        //　体力を一旦全削除
        for (int i = 0; i < transform.childCount; i++) {
            Destroy(transform.GetChild(i).gameObject);
        }
    void Start()
    {
        for (int i = 0; i < GlovalValue.HP; i++) {
            Instantiate<GameObject>(lifeObj, transform);
        }
    }
        //　現在の体力数分のライフゲージを作成
        
    }
    //　ダメージ分だけ削除
    public void SetLifeGauge2(int damage) {
        for (int i = 0; i < damage; i++) {
            //　最後のライフゲージを削除
            Destroy(transform.GetChild(i).gameObject);
            //Destroy(transform.GetChild(transform.childCount - 1 - i).gameObject);
        }
    }
}