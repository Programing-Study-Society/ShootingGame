using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
        void Update()
        {
        if(GlovalValue.HP <= 0)
        {
        // 現在のシーンの名前を取得する。
        // 「静的クラス」の中の「静的メソッド」を実行する。
        // 静的クラスはインスタンスしなくても実行できる（ポイント）
            comeGameover.CurrentSceneName();
            Debug.Log("シーン移動");

            SceneManager.LoadScene("GameOverScene");

        }
        }
}