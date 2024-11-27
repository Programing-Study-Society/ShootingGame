using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
public GameObject PanelUIObj;
    //Panelを表示する
    public void InactivatePanel()
    {
        PanelUIObj.SetActive(true);
    }
}
