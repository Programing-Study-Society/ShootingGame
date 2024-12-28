using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelection : MonoBehaviour
{

    public List<Button> stageButtonList;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < GlovalValue.firstStageClear.Count; i++){
            if(GlovalValue.firstStageClear[i]){
                stageButtonList[i].interactable = true;
            }
            else{
                stageButtonList[i].interactable = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
