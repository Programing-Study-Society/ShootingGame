using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelUpOnButton(){
        GlovalValue.playerLevelExperience += GlovalValue.score;
        while(GlovalValue.playerLevelExperience >= ((GlovalValue.playerLevel + 1) * 1000)){
            GlovalValue.playerLevel++;
            GlovalValue.playerLevelExperience -= GlovalValue.playerLevel * 1000;
        }
    }
}