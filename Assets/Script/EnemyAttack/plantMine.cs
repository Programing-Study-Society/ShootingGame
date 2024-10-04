using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantMine : MonoBehaviour
{
    [SerializeField, Header("�n���I�u�W�F�N�g")]
    private GameObject attack1;
    [SerializeField, Header("�n����u������")]
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

    private void shooting()
    {
        //shootTime�̒l���҂��Ȃ��Ǝ��s���Ȃ�
        shootCount += Time.deltaTime;
        if (shootCount < shootTime) return;

        //�A�^�b�N�I�u�W�F�N�g����
        GameObject atkObj1 = Instantiate(attack1);

        //�A�^�b�N�I�u�W�F�N�g�̍��W�ݒ�
        atkObj1.transform.position = transform.position +
            new Vector3(0f, transform.lossyScale.y / 2.0f, 0f);
        
        //�J�E���g������������
        shootCount = 0f;
    }
}
