using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ライブラリの追加
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour {  
    
    public GameObject gameObject;

    //始まった時に実行する関数　　
    void Start () {
        if (GlovalValue.Difficulty == 0) {
            //ボタンが押された時、StartGame関数を実行　
            gameObject.GetComponent<Button>().onClick.AddListener(StartGame); 
            // StartGame関数　
            void StartGame() { 
                // GameSceneをロード　
                SceneManager.LoadScene("GameScene"); 
                gameObject.GetComponent<Button>().onClick.AddListener(StartGame); 
            }
        }
        
        else {
            //ボタンが押された時、StartGame関数を実行　
            gameObject.GetComponent<Button>().onClick.AddListener(StartGame); 
            // StartGame関数　
            void StartGame() { 
                // GameSceneをロード　
                SceneManager.LoadScene("Home_Scene"); 
                gameObject.GetComponent<Button>().onClick.AddListener(StartGame); 
            }
        }
    }
}
