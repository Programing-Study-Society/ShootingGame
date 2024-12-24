using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChengeManeger : MonoBehaviour
{
    [SerializeField, Header("移動したいシーンの名前")]
    public string SceneName;

    [SerializeField, Header("シーン移動を付与したいボタンオブジェクトリスト")]

    public List<GameObject> buttonObject;
    
    void Start () {
        //ボタンが押された時、StartGame関数を実行　
        for(int i = 0; i < buttonObject.Count; i++){
            buttonObject[i].GetComponent<Button>().onClick.AddListener(OnClick); 
        } 
        // OnClick関数　
        void OnClick() { 
            // GameSceneをロード　
            SceneManager.LoadScene(SceneName); 
            //gameObject.GetComponent<Button>().onClick.AddListener(StartGame); 
        }
        
    }
}
