using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeWayAttack : MonoBehaviour
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
        shootCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        shooting();
    }

    //3�����U��
    private void shooting()
    {
        //shootTime�̒l���҂��Ȃ��Ǝ��s���Ȃ�
        shootCount += Time.deltaTime;
        if (shootCount < shootTime) return;

        //�A�^�b�N�I�u�W�F�N�g����
        GameObject atkObj1 = Instantiate(attack1);
        GameObject atkObj2 = Instantiate(attack1);
        GameObject atkObj3 = Instantiate(attack1);

        //�A�^�b�N�I�u�W�F�N�g�̍��W�ݒ�
        atkObj1.transform.position = transform.position + 
            new Vector3(0f,transform.lossyScale.y / 2.0f,0f);
        atkObj2.transform.position = transform.position +
            new Vector3(0f, transform.lossyScale.y / 2.0f, 0f);
        atkObj3.transform.position = transform.position +
            new Vector3(0f, transform.lossyScale.y / 2.0f, 0f);

        //�v���C���[�̍��W����G�l�~�[�̍��W�������Ă��̊Ԃ̃x�N�g�����v�Z
        Vector3 dir1 = new Vector3(randomF(), randomF(), 0.0f);
        Vector3 dir2 = new Vector3(randomF(), randomF(), 0.0f);
        Vector3 dir3 = new Vector3(randomF(), randomF(), 0.0f);
        
        //�I�u�W�F�N�g�̌�����dir�̃x�N�g���̕����ɕύX
        atkObj1.transform.rotation = Quaternion.FromToRotation(transform.up, dir1);
        atkObj2.transform.rotation = Quaternion.FromToRotation(transform.up, dir2);
        atkObj3.transform.rotation = Quaternion.FromToRotation(transform.up, dir3);

        //�J�E���g������������
        shootCount = 0f;
    }

    private float randomF()
    {
        float dir = Random.Range(-1.0f, 1.0f);

        return dir;
    } 
}
