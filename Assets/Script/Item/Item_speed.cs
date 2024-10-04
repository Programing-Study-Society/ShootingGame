using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Item_speed : MonoBehaviour
{
    private float speed;
    public moveController control;
    private string playerTag = "Player";
    
    void OnTriggerEnter2D(Collider2D other)
    //何が当たったか
{
    if (other.gameObject.CompareTag("Player"))
    {
        // 強化処理、プレイヤーの速さ
        control.speed *= 2;

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
        speed = control.speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
