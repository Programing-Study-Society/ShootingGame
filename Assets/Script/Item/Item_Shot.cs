using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Shot : MonoBehaviour
{    
   public PlayerStatas playerstatas;
    public moveController control;
    private string playerTag = "Player";

    public int attack;

    public AudioSource itemSE;

    void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        // 弾のダメージ強化処理
        playerstatas.ATK += 1;

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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
