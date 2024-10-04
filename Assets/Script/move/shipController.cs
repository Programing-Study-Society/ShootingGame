using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipController : MonoBehaviour
{
    public float speed;
    public Camera m_camera;

    void Start()
    {
        m_camera = Camera.main;  // ���C���J�������擾
    }

    void Update()
    {
        // �}�E�X�̃X�N���[�����W�����[���h���W�ɕϊ�
        var worldPoint = m_camera.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 0f;  // 2D��ԂƂ��Ĉ������߁Az���W��0�ɌŒ�

        // �L�����N�^�[����}�E�X�̕����ւ̃x�N�g�����v�Z
        Vector3 direction = worldPoint - transform.position;

        // �L�����N�^�[�̌������}�E�X�̕����ɉ�]������
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;  // �x�N�g���̊p�x���v�Z
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));  // ��]�p�x��ݒ�
    }
}

