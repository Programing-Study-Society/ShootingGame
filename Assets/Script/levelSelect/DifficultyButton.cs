using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    public int difficulty;

    public void OnClick()
    {
        GlovalValue.Difficulty = difficulty;
        Debug.Log(GlovalValue.Difficulty);
    } 
}