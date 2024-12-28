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
        StartStatas();
    }
    void FixedUpdate(){
        //Debug.Log("ATK:"+ATK);
        //Debug.Log("SPD:"+SPD);
    }
    public void StartStatas(){
        HP = GlovalValue.MaxHP;
        ATK = GlovalValue.attack;
        SPD = 2 + ((float)(GlovalValue.speed * 0.1) * 2);
    }
}
