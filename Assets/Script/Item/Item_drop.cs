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
        int rnd = Random.Range(0,99); // ※ 0.1～9.9の範囲でランダムな小数点数値が返る

        if(enemyStatas.HP <= 0)
        {
            if(rnd <= perdrop)
            Instantiate(itemPrefab, transform.position,Quaternion.identity);
        }
    }
}