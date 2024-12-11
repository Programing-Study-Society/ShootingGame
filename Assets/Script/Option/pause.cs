using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    private bool isPaused = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0.0f;
        isPaused = true;
        Debug.Log("一時停止中");
    }

    void ResumeGame()
    {
        Time.timeScale = 1.0f;
        isPaused = false;

        AudioListener.pause = false;
    }
}


