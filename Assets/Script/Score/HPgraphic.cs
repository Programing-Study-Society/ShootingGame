using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPgraphic : MonoBehaviour
{
    public GameObject[] lifeArray = new GameObject[5];
    private int lifePoint = GlovalValue.HP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && lifePoint<5)
        {
            lifePoint++;
            lifeArray[lifePoint-1].SetActive(true);
        }
        else if(Input.GetMouseButtonDown(1) && lifePoint>0)
        {
            lifeArray[lifePoint-1].SetActive(false);
            lifePoint--;
        }
    }

}
