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

    public AudioSource damegeSE;
    public GameObject explotionEffect;

    // Start is called before the first frame update
    void Start()
    {
        StartStatas();
    }
    void FixedUpdate(){
        //Debug.Log("ATK:"+ATK);
        //Debug.Log("SPD:"+SPD);
        if(GlovalValue.HP != HP){
            
            if(GlovalValue.HP < HP){
                damegeSE.Play();
            }
            HP = GlovalValue.HP;
        }
        if(GlovalValue.HP <= 0){
            GameObject effect = Instantiate(explotionEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
            Destroy(this.gameObject);
        }
    }
    public void StartStatas(){
        HP = GlovalValue.MaxHP;
        ATK = GlovalValue.attack;
        SPD = 2 + ((float)(GlovalValue.speed * 0.1) * 2);
    }
}
