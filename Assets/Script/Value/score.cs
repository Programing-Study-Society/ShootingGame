using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject score_object;
    Text score_text;

    // Start is called before the first frame update
    void Start()
    {
        //GetCompornentはstartへ
        score_text = score_object.GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = "000000";
    }
}
