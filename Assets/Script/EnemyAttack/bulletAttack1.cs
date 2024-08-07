using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletAttack1 : MonoBehaviour
{
    [SerializeField, Header("player�I�u�W�F�N�g")]
    private GameObject player;
    [SerializeField, Header("�e�I�u�W�F�N�g")]
    private GameObject attack1;
    [SerializeField, Header("�e�𔭎˂��鎞��")]
    private float shootTime;

    private float shootCount;
    

    // Start is called before the first frame update
    void Start()
    {
        shootCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        shooting();
    }

    private void shooting()
    {
        shootCount += Time.deltaTime;
        if (shootCount < shootTime) return;

        GameObject atkObj = Instantiate(attack1);
        atkObj.transform.position = transform.position + 
            new Vector3(0f,transform.lossyScale.y / 2.0f,0f);

        Vector3 dir = player.transform.position - transform.position;

        atkObj.transform.rotation = Quaternion.FromToRotation(transform.up, dir);

        shootCount = 0f;
    }
}
