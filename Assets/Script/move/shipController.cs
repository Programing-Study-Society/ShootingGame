using UnityEngine;

public class shipController : MonoBehaviour
{
    float moveSpeed = 5;
    [SerializeField] Rigidbody2D rb;

    Vector2 movement;
    Vector2 mousePos;
    //�J�����̎Q��
    [SerializeField] Camera camera;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        movement.y = Input.GetAxisRaw("Vertical");
        //�}�E�X�̈ʒu���擾
        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        //�}�E�X�̌������擾
        Vector2 lookDir = mousePos - rb.position;
        //�}�E�X�̊p�x���擾����
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
