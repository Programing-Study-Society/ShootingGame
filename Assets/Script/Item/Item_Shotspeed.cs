using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Shotspeed : MonoBehaviour
{
    public leftClickAttack Shotspeed;
    public moveController control;
    public bool attackStrengthening;
    private string playerTag = "Player";
    public AudioSource itemSE;
    void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        // 強化処理、プレイヤーの弾の速度を上げる？発射速度？
        Shotspeed.attackStrengthening = true;
        itemSE.Play();

        // アイテムを消す
        Destroy(this.gameObject);
    }
}
    private void OnCollisionEnter2D(Collision2D collision)
{
        if (collision.collider.tag == playerTag)
        {
            Debug.Log("プレイヤーと接触した！");
        }
}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
