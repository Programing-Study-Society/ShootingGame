using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlArea : MonoBehaviour
{
    //playerが移動できるXとYの上限
    public GameObject mainCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        //カメラの距離に対応して動ける範囲を変更
        GlovalValue.xLimit = -0.4f + -mainCamera.transform.position.z + (-mainCamera.transform.position.z * 0.01f);
        GlovalValue.yLimit = 0.4f + (-mainCamera.transform.position.z * 0.53f);
        //Debug.Log(xLimit);
        //Debug.Log(yLimit);
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
        currentPos.x = Mathf.Clamp(currentPos.x, -GlovalValue.xLimit + cameraPos.x, GlovalValue.xLimit + cameraPos.x);
        currentPos.y = Mathf.Clamp(currentPos.y, -GlovalValue.yLimit + cameraPos.y, GlovalValue.yLimit + cameraPos.y);

        //追加　positionをcurrentPosにする
        transform.position = currentPos;
    }
}
