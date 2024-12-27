using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatas : MonoBehaviour
{
    [SerializeField, Header("エネミーのHP")]
    public float HP;
    [SerializeField, Header("エネミーの攻撃力")]
    public int ATK;
    [SerializeField, Header("エネミーの速度")]
    public float SPD;

    [SerializeField, Header("爆発エフェクト")]
    public GameObject explotionEffect;

    [SerializeField, Header("エネミースコア")]
    private int score;

    [SerializeField, Header("ドロップアイテム")]
    public List<GameObject> itemPrefab;

    [SerializeField, Header("ドロップ確率")]
    public int perdrop;


    void Start()
    {
        //scoreをHPの10倍の数値とする
        score = (int)(HP * 10);
    }

    void Update()
    {
        if (HP <= 0)
        {
            GlovalValue.score += score;
            //Debug.Log(GlovalValue.score);
            Destroy(this.gameObject);
            GameObject effect = Instantiate(explotionEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
            int rnd = Random.Range(0,100); // ※ 0～99の範囲でランダムな小数点数値が返る
            int rndpop = Random.Range(0, itemPrefab.Count);
            if(rnd <= perdrop){
                Instantiate(itemPrefab[rndpop], transform.position,Quaternion.identity);
            }

        }
    }
}
