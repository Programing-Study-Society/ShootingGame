using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject score_object;

    // Start is called before the first frame update
    void Start()
    {
        //GetCompornentはstartへ
        Text score_text = score_object.GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        Text score_text.text = "000000";
    }
}
