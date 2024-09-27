using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Shot : MonoBehaviour
{    
    void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.CompareTag("Item"))
    {
        // 強化処理
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
