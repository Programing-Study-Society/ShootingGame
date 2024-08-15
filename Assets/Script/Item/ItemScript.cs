using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineUI;

public class ItemScript : MonoBehaviour
public class Efficacy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    {
    // 対象となるステータス
    public CharacterStatusParams status;
    // 値
    public ushort value;
    
    public Efficacy( CharacterStatusParams status, ushort value )
    {
        this.status = status;
        this.value = value;
    }
    }
}
