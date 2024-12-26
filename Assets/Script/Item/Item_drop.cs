using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item_drop : MonoBehaviour
{

    [SerializeField, Header("ドロップアイテム")]
    public GameObject itemPrefab;

    [SerializeField, Header("ドロップ確率")]
    public int perdrop;

    public EnemyStatas enemyStatas;
    void Update()
    {

        if(enemyStatas.HP <= 0)
        {
            int rnd = Random.Range(0,100); // ※ 0～99の範囲でランダムな小数点数値が返る
            if(rnd <= perdrop)
            Instantiate(itemPrefab, transform.position,Quaternion.identity);
        }
    }
}