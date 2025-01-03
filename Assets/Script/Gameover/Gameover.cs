using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{

    float time = 0.0f;
    void Start(){
        time = 0.0f;
    }
    void Update()
    {
        if(GlovalValue.HP <= 0)
        {
            time += Time.deltaTime;
            if(time <= 0.6f){
                return;
            }
        // 現在のシーンの名前を取得する。
        // 「静的クラス」の中の「静的メソッド」を実行する。
        // 静的クラスはインスタンスしなくても実行できる（ポイント）
            comeGameover.CurrentSceneName();
            //Debug.Log("シーン移動");

            SceneManager.LoadScene("GameOverScene");

        }
        if(GlovalValue.stageclear){
            comeGameover.CurrentSceneName();
            //Debug.Log("シーン移動");

            SceneManager.LoadScene("GameOverScene");
        }
    }
}