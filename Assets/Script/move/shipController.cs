using UnityEngine;

public class shipController : MonoBehaviour
{
    void Update()
    {
        if(GlovalValue.pauseFlag){
            return;
        }
        
        var pos = Camera.main.WorldToScreenPoint(transform.localPosition);
        var rotation = Quaternion.LookRotation(Vector3.forward, Input.mousePosition - pos);
        transform.localRotation = rotation;
        //Debug.Log(transform.localRotation);
    }
}
