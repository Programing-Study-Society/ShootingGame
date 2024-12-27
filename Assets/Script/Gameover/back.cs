using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
    void Start (){ 
        //ボタンが押された時、StartGame関数を実行　
        gameObject.GetComponent<Button>().onClick.AddListener(StartGame);
        // StartGame関数　
        void StartGame(){
            ScoreRanking();
            GlovalValue.score = 0;
            GlovalValue.stageclear = false;
            GlovalValue.HP = GlovalValue.MaxHP;
            SceneManager.LoadScene("Home_Scene"); 
            gameObject.GetComponent<Button>().onClick.AddListener(StartGame);
        }  
    } 

    public void BackToBeforeScene()
    {
        ScoreRanking();
        GlovalValue.HP = GlovalValue.MaxHP;
        GlovalValue.score = 0;
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
