using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlArea : MonoBehaviour
{
    //playerが移動できるXとYの上限
    public GameObject mainCamera;
    float xLimit = 9.6f;
    float yLimit = 5.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //カメラの現在の位置を取得
        Vector3 cameraPos = mainCamera.transform.position;
        //現在のプレイヤーの位置を取得
        Vector3 currentPos = transform.position;

        //Mathf.ClampでX,Yの値それぞれが最小～最大の範囲内に収める。
        //範囲を超えていたら範囲内の値を代入する
        currentPos.x = Mathf.Clamp(currentPos.x, -xLimit + cameraPos.x, xLimit + cameraPos.x);
        currentPos.y = Mathf.Clamp(currentPos.y, -yLimit + cameraPos.y, yLimit + cameraPos.y);

        //追加　positionをcurrentPosにする
        transform.position = currentPos;
    }
}
