using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlArea : MonoBehaviour
{
    //player���ړ��ł���X��Y�̏��
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
        //�J�����̌��݂̈ʒu���擾
        Vector3 cameraPos = mainCamera.transform.position;
        //���݂̃v���C���[�̈ʒu���擾
        Vector3 currentPos = transform.position;

        //Mathf.Clamp��X,Y�̒l���ꂼ�ꂪ�ŏ��`�ő�͈͓̔��Ɏ��߂�B
        //�͈͂𒴂��Ă�����͈͓��̒l��������
        currentPos.x = Mathf.Clamp(currentPos.x, -xLimit + cameraPos.x, xLimit + cameraPos.x);
        currentPos.y = Mathf.Clamp(currentPos.y, -yLimit + cameraPos.y, yLimit + cameraPos.y);

        //�ǉ��@position��currentPos�ɂ���
        transform.position = currentPos;
    }
}
