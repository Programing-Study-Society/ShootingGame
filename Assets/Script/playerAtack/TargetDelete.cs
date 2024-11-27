using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDelete : MonoBehaviour
{

    public Collision collision;
    
    // Update is called once per frame
    void Update()
    {
        if(!collision.IsObject()){
            Destroy(this.gameObject);
        }
    }
}
