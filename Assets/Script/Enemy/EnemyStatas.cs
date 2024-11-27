using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatas : MonoBehaviour
{
    [SerializeField, Header("エネミーのHP")]
    public int HP;
    [SerializeField, Header("エネミーの攻撃力")]
    public int ATK;
    [SerializeField, Header("エネミーの速度")]
    public float SPD;

    [SerializeField, Header("爆発エフェクト")]
    public GameObject explotionEffect;

    [SerializeField, Header("エネミースコア")]
    public int score;

    void Update()
    {
        if (HP <= 0)
        {
            GlovalValue.score = score;
            Destroy(this.gameObject);
            GameObject effect = Instantiate(explotionEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
        }
    }
}
