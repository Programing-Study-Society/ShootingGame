using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ライブラリの追加
using UnityEngine.UI;
using UnityEngine.SceneManagement;
<<<<<<< HEAD
public class startButton : MonoBehaviour {  
    //始まった時に実行する関数　　
    void Start (){ 
        //ボタンが押された時、StartGame関数を実行　
        gameObject.GetComponent<Button>().onClick.AddListener(StartGame); } 
        // StartGame関数　
        void StartGame() { 
            // GameSceneをロード　
            SceneManager.LoadScene("GameScene"); 
        gameObject.GetComponent<Button>().onClick.AddListener(StartGame); 
    } 

    // StartGame関数　
    public void StartButton() { 
        // GameSceneをロード　
        SceneManager.LoadScene("GameScene"); 
    } 
}
=======

public class startButton : MonoBehaviour {  

    //始まった時に実行する関数
    void Start (){ 
        //ボタンが押された時、StartGame関数を実行　
        gameObject.GetComponent<Button>().onClick.AddListener(StartaGame); 
    } 
        
        // StartGame関数　
    Void StartGame() 
    {
         // GameSceneをロード
         SceneManager.LoadScene("GameScene"); 
    } 
}
>>>>>>> 2fe2f7f165cc5f525aa349173e83395fb0519163
