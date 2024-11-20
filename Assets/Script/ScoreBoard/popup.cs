using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class popup : MonoBehaviour
{
    public GameObject PanelUIObj;
    //Panelを消す
    public void InactivatePanel()
    {
        PanelUIObj.SetActive(false);
    }
}
