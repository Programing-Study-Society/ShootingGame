using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        if(GlovalValue.stageclear){
            text.text = "Clear!!";
            if(GlovalValue.firstStageClear.Count > comeGameover.count + 1){
                GlovalValue.firstStageClear[comeGameover.count + 1] = true;
            }
        }
        else{
            text.text = "Game Over";
        }
    }
}
