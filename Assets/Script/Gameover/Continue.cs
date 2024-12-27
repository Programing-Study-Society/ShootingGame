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
        ScoreRanking();
        GlovalValue.HP = GlovalValue.MaxHP;
        GlovalValue.score = 0;
        GlovalValue.stageclear = false;
        SceneManager.LoadScene(comeGameover.sceneName);
    }

    public void ScoreRanking(){
        for(int i = 0; i < 5; i++){
            if(GlovalValue.ScoreList[comeGameover.count,i] < GlovalValue.score){
                for(int j = 4; j > i; j--){
                    GlovalValue.ScoreList[comeGameover.count,j] = GlovalValue.ScoreList[comeGameover.count,j - 1];
                }
                GlovalValue.ScoreList[comeGameover.count,i] = GlovalValue.score;
                break;
            } 
        }
    }
}