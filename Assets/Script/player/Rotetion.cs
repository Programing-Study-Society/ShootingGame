using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotetion : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var pos = Camera.main.WorldToScreenPoint(transform.localPosition);
        var rotation = Quaternion.LookRotation(Vector3.forward, Input.mousePosition - pos);
        transform.localRotation = rotation;
    }
}
