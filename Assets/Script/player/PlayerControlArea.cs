using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlArea : MonoBehaviour
{
    //player���ړ��ł���X��Y�̏��
    public GameObject mainCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        //�J�����̋����ɑΉ����ē�����͈͂�ύX
        GlovalValue.xLimit = (-mainCamera.transform.position.z * 1.12f);
        GlovalValue.yLimit = (-mainCamera.transform.position.z * 0.55f);
        //Debug.Log(xLimit);
        //Debug.Log(yLimit);
    }

    // Update is called once per frame
    void Update()
    {
        //�J�����̌��݂̈ʒu���擾
        Vector3 cameraPos = mainCamera.transform.position;
        //���݂̃v���C���[�̈ʒu���擾
        Vector3 currentPos = transform.position;

        //Mathf.Clamp��X,Y�̒l���ꂼ�ꂪ�ŏ��`�ő�͈͓̔��Ɏ��߂�B
        //�͈͂𒴂��Ă�����͈͓��̒l��������
        currentPos.x = Mathf.Clamp(currentPos.x, -GlovalValue.xLimit + cameraPos.x, GlovalValue.xLimit + cameraPos.x);
        currentPos.y = Mathf.Clamp(currentPos.y, -GlovalValue.yLimit + cameraPos.y, GlovalValue.yLimit + cameraPos.y);

        //�ǉ��@position��currentPos�ɂ���
        transform.position = currentPos;
    }
}
