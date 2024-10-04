using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipController : MonoBehaviour
{
    public float speed;
    public Camera m_camera;

    void Start()
    {
        m_camera = Camera.main;  // メインカメラを取得
    }

    void Update()
    {
        // マウスのスクリーン座標をワールド座標に変換
        var worldPoint = m_camera.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 0f;  // 2D空間として扱うため、z座標を0に固定

        // キャラクターからマウスの方向へのベクトルを計算
        Vector3 direction = worldPoint - transform.position;

        // キャラクターの向きをマウスの方向に回転させる
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;  // ベクトルの角度を計算
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));  // 回転角度を設定
    }
}

