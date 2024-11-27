using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(isPause)
       {
        return;
       }
    }

    public void PauseGame()
    {
        Time.timeScale = 0.0f;
        isPause = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1.0f;
        isPause = false;
    }
}


