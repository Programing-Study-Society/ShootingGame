using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    //emptyにいれ、全ゲームシーンに導入。gameoverを呼び出す。
public static class comeGameover
{
    //シーン名を保存
    public static string sceneName;

    // 「このメソッドが実行された時に開いているシーンの名前」を取得する。
    // 今回の場合は、ゲームオーバーの条件が揃った時に、Gameoverでこのメソッドを呼び出す。
    public static void CurrentSceneName()
    {
        sceneName = SceneManager.GetActiveScene().name;
        Debug.Log(sceneName);
    }
}