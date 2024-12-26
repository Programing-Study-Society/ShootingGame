using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatas : MonoBehaviour
{
    [SerializeField, Header("HP")]
    public int HP;
    [SerializeField, Header("attack")]
    public int ATK;
    [SerializeField, Header("speed")]
    public float SPD;

    // Start is called before the first frame update
    void Start()
    {
        HP = GlovalValue.HP;
        ATK = GlovalValue.attack;
        SPD = GlovalValue.speed;
    }
}
