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

    void Update()
    {
        if (HP <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
