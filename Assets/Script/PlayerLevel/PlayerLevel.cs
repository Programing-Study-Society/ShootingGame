using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLevel : MonoBehaviour
{
    public Slider levelSlider;
    public Text levelText;
    public Text levelExperienceText;
    // Start is called before the first frame update
    void Start()
    {
        LevelDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelDisplay(){
        //テキスト表示
        if((GlovalValue.playerLevel + 1) * 1000 <= 20000){
            levelExperienceText.text = GlovalValue.playerLevelExperience.ToString() + "/" + ((GlovalValue.playerLevel + 1) * 1000).ToString();
        }
        else{
            levelExperienceText.text = GlovalValue.playerLevelExperience.ToString() + "/" + (20000).ToString();
        }
        levelText.text = GlovalValue.playerLevel.ToString();

        //スライダー表示
        if((GlovalValue.playerLevel + 1) * 1000 <= 20000){
            levelSlider.maxValue = ((GlovalValue.playerLevel + 1) * 1000);
        }
        else{
            levelSlider.maxValue = 20000;
        }
        levelSlider.value = GlovalValue.playerLevelExperience;
    }
}
