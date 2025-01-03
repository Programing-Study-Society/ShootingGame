using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item_heal : MonoBehaviour
{
    public int playerHP;
    //public moveController control;
    private string playerTag = "Player";

    public AudioSource itemSE;
    void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        // 強化処理
        GlovalValue.HP += 1;

        itemSE.Play();

        // アイテムを消す
        Destroy(this.gameObject);
    }
}

    private void OnCollisionEnter2D(Collision2D collision)
{
        if (collision.collider.tag == playerTag)
        {
            Debug.Log("プレイヤーと接触した！");
        }
}
    // Start is called before the first frame update
    void Start()
    {
        playerHP = GlovalValue.HP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
