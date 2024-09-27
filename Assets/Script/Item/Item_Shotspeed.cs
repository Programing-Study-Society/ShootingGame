using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Shotspeed : MonoBehaviour
{
    private string playerTag = "Player";
    void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        // 強化処理、プレイヤーの弾の速度を上げる？発射速度？
        // += 2;

        // アイテムを消す
        Destroy(other.gameObject);
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
