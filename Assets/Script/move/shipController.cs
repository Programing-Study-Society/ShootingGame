using UnityEngine;

public class shipController : MonoBehaviour
{
    float moveSpeed = 5;
    [SerializeField] Rigidbody2D rb;

    Vector2 movement;
    Vector2 mousePos;
    //カメラの参照
    [SerializeField] Camera camera;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        movement.y = Input.GetAxisRaw("Vertical");
        //マウスの位置を取得
        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        //マウスの向きを取得
        Vector2 lookDir = mousePos - rb.position;
        //マウスの角度を取得する
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
