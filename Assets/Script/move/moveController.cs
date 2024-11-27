using UnityEngine;
using System.Collections;

public class moveController: MonoBehaviour
{
    [HideInInspector]public float speed = GlovalValue.speed / 100;
    // 速度
    [HideInInspector]public Vector2 SPEED = new Vector2(GlovalValue.speed / 100, GlovalValue.speed / 100);
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 移動処理
        Move();
    }

    // 移動関数
    void Move()
    {
        // 現在位置をPositionに代入
        float moveX = 0f;
        float moveY = 0f;
        Vector2 Position = transform.position;
        // 左キーを押し続けていたら
        if (Input.GetKey("left") || Input.GetKey (KeyCode.A))
        {
            // 代入したPositionに対して加算減算を行う
            moveX -= SPEED.x;
        }
        else if (Input.GetKey("right") || Input.GetKey (KeyCode.D))
        { // 右キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
            moveX += SPEED.x;
        }
        if (Input.GetKey("up") || Input.GetKey (KeyCode.W))
        { // 上キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
            moveY += SPEED.y;
        }
        else if (Input.GetKey("down") || Input.GetKey (KeyCode.S)) 
        { // 下キーを押し続けていたら
          // 代入したPositionに対して加算減算を行う
            moveY -= SPEED.y;
        }
        if (moveX != 0f && moveY != 0f)
        {
            moveX /= 1.4f;
            moveY /= 1.4f;
        }
        Position.x += moveX;
        Position.y += moveY;
        // 現在の位置に加算減算を行ったPositionを代入する
        transform.position = Position;
    }


}
