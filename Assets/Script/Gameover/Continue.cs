using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Continue : MonoBehaviour
{

    // 上記のメソッドで取得されたシーンに戻る。
    // 今回の場合は、コンティニューボタンを押した時にこのメソッドを実行する。
    public void BackToBeforeScene()
    {
        SceneManager.LoadScene(comeGameover.sceneName);
        GlovalValue.HP = GlovalValue.MaxHP;
        GlovalValue.score = 0;
    }
}