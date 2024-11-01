using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatas : MonoBehaviour
{
    [SerializeField, Header("プレイヤーのHP")]
    public int HP;
    [SerializeField, Header("プレイヤーの攻撃力")]
    public int ATK;
    [SerializeField, Header("プレイヤーの速度")]
    public float SPD;

    // Start is called before the first frame update
    void Start()
    {
        GlovalValue.HP = HP;
        GlovalValue.attack = ATK;
    }
}
