using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyText : MonoBehaviour
{
    public Text text;
 
    // Start is called before the first frame update
    void Start()
    {
        DifficultySelection();
    }

    public void DifficultySelection(){
        if(GlovalValue.Difficulty == 1){
            text.text = "現在：Easy";
        }
        else if(GlovalValue.Difficulty == 2){
            text.text = "現在：Normal";
        }
        else if(GlovalValue.Difficulty == 3){
            text.text = "現在：Hard";
        }
        else if(GlovalValue.Difficulty == 4){
            text.text = "現在：Master";
        }
    }
}
