using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChengeScene : MonoBehaviour
{
    public string SceneName;

    void Start () {
        this.gameObject.GetComponent<Button>().onClick.AddListener(OnClick);
        
        void OnClick(){
            GlovalValue.HP = GlovalValue.MaxHP;
            SceneManager.LoadScene(SceneName);
        }
    }

    
}
