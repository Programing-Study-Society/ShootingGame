
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PursuitAttack: MonoBehaviour
{
    [SerializeField, Header("player�I�u�W�F�N�g")]
    private GameObject player;
    [SerializeField, Header("�e�I�u�W�F�N�g")]
    private GameObject attack1;
    [SerializeField, Header("�e�𔭎˂��鎞��")]
    private float shootTime;

    private float shootCount;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        shootCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        shooting();
    }

    //�ǔ��U��
    private void shooting()
    {
        //shootTime�̒l���҂��Ȃ��Ǝ��s���Ȃ�
        shootCount += Time.deltaTime;
        if (shootCount < shootTime) return;

        //�A�^�b�N�I�u�W�F�N�g����
        GameObject atkObj1 = Instantiate(attack1);

        //�A�^�b�N�I�u�W�F�N�g�̍��W�ݒ�
        atkObj1.transform.position = transform.position + 
            new Vector3(0f,transform.lossyScale.y / 2.0f,0f);

        //�v���C���[�̍��W�ƃG�l�~�[�̍��W�Ƃ̊Ԃ̃x�N�g���v�Z
        Vector3 dir = player.transform.position - transform.position;

        //�I�u�W�F�N�g�̌�����dir�̃x�N�g���̕����ɕύX
        atkObj1.transform.rotation = Quaternion.FromToRotation(transform.up, dir);

        //�J�E���g������������
        shootCount = 0f;
    }
}
