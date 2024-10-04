using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Shot : MonoBehaviour
{    
    public static int attack = 1;
    public moveController control;
    private string playerTag = "Player";

    void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        // 弾の強化処理
        attack += 1;

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
