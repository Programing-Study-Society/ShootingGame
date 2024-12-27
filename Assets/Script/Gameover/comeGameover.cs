using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    //これは使わない。
public static class comeGameover
{
    //シーン名を保存
    public static string sceneName;

    public static int count = 0;

    // 「このメソッドが実行された時に開いているシーンの名前」を取得する。
    // 今回の場合は、ゲームオーバーの条件が揃った時に、Gameoverでこのメソッドを呼び出す。
    public static void CurrentSceneName()
    {
        sceneName = SceneManager.GetActiveScene().name;
        if(sceneName == "Stage1"){
            count = 0;
        }
        else if(sceneName == "Stage2"){
            count = 1;
        }
        else if(sceneName == "Stage3"){
            count = 2;
        }
        else if(sceneName == "Stage4"){
            count = 3;
        }
        Debug.Log(sceneName);
        Debug.Log(count);
    }
}