using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item_heal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.CompareTag("Item"))
    {
        // 強化処理
        //CharacterHP += 1;

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
