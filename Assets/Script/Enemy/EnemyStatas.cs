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

    [HideInInspector]public int score;

    [SerializeField, Header("ドロップアイテム")]
    public List<GameObject> itemPrefab;

    [SerializeField, Header("ドロップ確率")]
    public int perdrop;


    void Start()
    {
        //scoreをHPの10倍の数値とする
        HP = GlovalValue.difficultyEnemyHP[GlovalValue.Difficulty - 1] * HP;
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
            int rndpop;
            //Debug.Log(itemPrefab.Count);
            if(itemPrefab.Count < 2){
                rndpop = 0;
            }else{
                rndpop = Random.Range(0, itemPrefab.Count - 1);
            }
            if(itemPrefab.Count != 0){
                if(itemPrefab[rndpop] != null){
                    if(rnd <= perdrop){
                        Instantiate(itemPrefab[rndpop], transform.position,Quaternion.identity);
                    }
                }
            }
        }
    }
}
