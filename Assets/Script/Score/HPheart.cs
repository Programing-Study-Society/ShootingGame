using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPheart : MonoBehaviour
{
    public GameObject heartPrefab; // ハートのプレハブ
    public Transform heartsContainer; // ハートを配置する親オブジェクト
    private int OldHP;

    void Start()
    {
        UpdateHearts();
    }

    void Update()
    {
        if(GlovalValue.HP != OldHP)
        {
            UpdateHearts();
            OldHP = GlovalValue.HP;
        }
    }

    private void UpdateHearts()
    {
        //Debug.Log(heartsContainer);
        // 既存のハートを削除
        foreach (Transform child in heartsContainer)
        {
            Destroy(child.gameObject);
            
        }

        // 現在のHPに応じてハートを生成
        for (int i = 0; i < GlovalValue.HP; i++)
        {
            //Debug.Log(GlovalValue.HP);
            GameObject heart = Instantiate(heartPrefab/*, heartsContainer*/);
            heart.transform.SetParent(heartsContainer, false);
            heart.transform.position = heartsContainer.position + new Vector3(i * 40, 0, 0);
            //heart.GetComponent<RectTransform>().anchoredPosition = new Vector2(i * 40, 0); // ハートの位置を調整
        }
    }


}
