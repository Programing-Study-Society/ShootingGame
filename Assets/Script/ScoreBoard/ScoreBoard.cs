using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    //GlovalValue.ScoreList;

public class ScoreBoard : MonoBehaviour
{
    public Text score_text;

    public int StageSelect;

    public void OnClick()
    {
        score_text.text = GlovalValue.ScoreList[StageSelect-1,0].ToString()+"\n\n\n";
        score_text.text += GlovalValue.ScoreList[StageSelect-1,1].ToString()+"\n\n\n";
        score_text.text += GlovalValue.ScoreList[StageSelect-1,2].ToString()+"\n\n\n";
        score_text.text += GlovalValue.ScoreList[StageSelect-1,3].ToString()+"\n\n\n";
        score_text.text += GlovalValue.ScoreList[StageSelect-1,4].ToString();

        //ScoreList[0,0]

    }
}