using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarEnemy : MonoBehaviour
{

    public EnemyCollision enemyCollision;

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RadarScan();
    }

    public void RadarScan(){
        if(enemyCollision.IsEnemy()){
            for(int i = 0; i < enemyCollision.colList.Count; i++){
                if(enemyCollision.colList[i] != null){
                    var parent = enemyCollision.colList[i].transform;
                    Transform child = parent.Find("Target(Clone)");
                    if(child == null){
                        Instantiate(target, parent);
                    }
                }
                
            }
        }
    }
}
