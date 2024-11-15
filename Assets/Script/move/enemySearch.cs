using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySearch : MonoBehaviour
{
    private FirstMovement firstMovement;
    Transform playerTr;
    [SerializeField] float speed = 2; //エネミーの速度
    // Start is called before the first frame update
    private void Start()
    {
        playerTr = GameObject.FindGameObjectWithTag("Player").transform;
        firstMovement = this.gameObject.GetComponent<FirstMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(firstMovement.firstMove) return;
        //プレイヤーとの距離が0,1ｆ未満になったら実行しない
        if (Vector2.Distance(transform.position, playerTr.position) < 0.1f)
        return;

        //プレイヤーを追撃
        transform.position = Vector2.MoveTowards(
            transform.position,
            new Vector2(playerTr.position.x, playerTr.position.y),
            speed * Time.deltaTime);
    }
}
