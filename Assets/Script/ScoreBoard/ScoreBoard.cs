using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    //GlovalValue.ScoreList;

public class ScoreBoard : MonoBehaviour
{
    public Text score_text;

    public int StageSelect;
    public string stageName;
    public GameObject scoreboard;

    public void OnClick()
    {
        score_text.text = stageName+"\n\n";
        score_text.text += "1st : " + GlovalValue.ScoreList[StageSelect-1,0].ToString()+"\n\n";
        score_text.text += "2st : " + GlovalValue.ScoreList[StageSelect-1,1].ToString()+"\n\n";
        score_text.text += "3st : " + GlovalValue.ScoreList[StageSelect-1,2].ToString()+"\n\n";
        score_text.text += "4st : " + GlovalValue.ScoreList[StageSelect-1,3].ToString()+"\n\n";
        score_text.text += "5st : " + GlovalValue.ScoreList[StageSelect-1,4].ToString();
        
        //ScoreList[0,0]

    }
}