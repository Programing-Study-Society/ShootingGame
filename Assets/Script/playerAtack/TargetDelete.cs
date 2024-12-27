using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDelete : MonoBehaviour
{

    public Collision collision;
    public float time = 0.0f;
    
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time < 0.1)return;
        if(!collision.IsObject()){
            Destroy(this.gameObject);
        }
    }
}
