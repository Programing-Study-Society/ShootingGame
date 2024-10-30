using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPheart : MonoBehaviour
{
    public int maxHP = 10; // 最大HP
    public int currentHP; // 現在のHP
    public GameObject heartPrefab; // ハートのプレハブ
    public Transform heartsContainer; // ハートを配置する親オブジェクト

    private void Start()
    {
        currentHP = maxHP;
        UpdateHearts();
    }

    public void IncreaseHP(int amount)
    {
        currentHP = Mathf.Min(currentHP + amount, maxHP);
        UpdateHearts();
    }

    public void DecreaseHP(int amount)
    {
        currentHP = Mathf.Max(currentHP - amount, 0);
        UpdateHearts();
    }

    private void UpdateHearts()
    {
        // 既存のハートを削除
        foreach (Transform child in heartsContainer)
        {
            Destroy(child.gameObject);
        }

        // 現在のHPに応じてハートを生成
        for (int i = 0; i < currentHP; i++)
        {
            GameObject heart = Instantiate(heartPrefab, heartsContainer);
            heart.GetComponent<RectTransform>().anchoredPosition = new Vector2(i * 40, 0); // ハートの位置を調整
        }
    }
}
