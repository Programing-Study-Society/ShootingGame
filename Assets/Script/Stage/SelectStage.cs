using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectStage : MonoBehaviour
{

    public string sceneName;
    public int stageCount;

    public Button startSceneButton;

    public List<GameObject> stageStory;

    // Start is called before the first frame update
    void Start()
    {
        sceneName = "void";
        startSceneButton.onClick.AddListener(OnClick);
        
        void OnClick(){
            if(sceneName != "void"){
                GlovalValue.HP = GlovalValue.MaxHP;
                SceneManager.LoadScene(sceneName);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StageNumber(int count){
        if(count == 0){
            sceneName = "Stage1";
        }
        else if(count == 1){
            sceneName = "Stage2";
        }
        else if(count == 2){
            sceneName = "Stage3";
        }
        else if(count == 3){
            sceneName = "Stage4";
        }

        for(int i = 0 ;i < stageStory.Count; i++){
            if(i == count){
                stageStory[i].SetActive(true);
            }else{
                stageStory[i].SetActive(false);
            }
        }

        //Debug.Log(sceneName);
        //Debug.Log(count);
    }
}
