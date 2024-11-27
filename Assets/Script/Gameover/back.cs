using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{
    // Start is called before the first frame update
    public void change_button()
    {
        SceneManager.LoadScene("GameScene1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
