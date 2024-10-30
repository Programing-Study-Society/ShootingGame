using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPpanel : MonoBehaviour
{
    ObservedValue<GlobalValue.HP> count;
    //　ライフゲージプレハブ
    [SerializeField]
    private GameObject lifeObj;

    void Start()
    {
        for (int i = 0; i <= GlovalValue.HP; i++) {
            Instantiate<GameObject>(lifeObj, transform);
        }
    }

    void Update()
    {
        if(int i = );   
    }
    public void SetLifeGauge() {
        if (int i = 0; i < GlovalValue.HP; i--) {
            //　最後のライフゲージを削除
            Destroy(transform.GetChild(i).gameObject);
            //Destroy(transform.GetChild(transform.childCount - 1 - i).gameObject);
        }
    }
}

//HPnot=のとき実行させて、destroy