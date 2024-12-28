using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Item_speed : MonoBehaviour
{
    public float speed;
    public PlayerStatas playerstatas;
    private string playerTag = "Player";

    public AudioSource itemSE;
    
    void OnTriggerEnter2D(Collider2D other)
    //何が当たったか
{
    if (other.gameObject.CompareTag("Player"))
    {
        // 強化処理、プレイヤーの速さ
        speed += 0.10f;
        playerstatas.SPD += speed;
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
