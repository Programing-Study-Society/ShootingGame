using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineExplosion : MonoBehaviour
{
    bool isPlayerEnter = false;
    string PLAYER_TAG = "Player";

    [SerializeField, Header("�n���̈З�")]
    private int power;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerEnter)
        {
            GlovalValue.HP -= power;
            Debug.Log(GlovalValue.HP);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == PLAYER_TAG)
        {
            isPlayerEnter = true;
            Debug.Log("�v���C���[������ɓ���܂���");
        }

    }

}
