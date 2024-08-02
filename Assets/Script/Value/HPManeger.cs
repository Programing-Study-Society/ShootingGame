using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManeger : MonoBehaviour
{

    private State_Player _State;
    private Life_children[] _Hearts;

    // Start is called before the first frame update
    void Start()
    {
        _State = GameObject.FindGameobjectsWithTag("HPManeger")[0].GetCompornent<State_Player>();

        _Hearts = new Life_children[20];

        _getChildObjScript;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void _getChildObjScript(

        int i = 0;
        foreach (Transform Child in transform)
        {
            _Hearts[i] = child.GetCompornent<LifeChildren>();
        }
    )
}
