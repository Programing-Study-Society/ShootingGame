using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
    void Start (){ 
        //ボタンが押された時、StartGame関数を実行　
        gameObject.GetComponent<Button>().onClick.AddListener(StartGame); } 
        // StartGame関数　
        void StartGame() { 
            SceneManager.LoadScene("Home_Scene"); 
        gameObject.GetComponent<Button>().onClick.AddListener(StartGame); 
    } 

}
