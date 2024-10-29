using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTemplate : MonoBehaviour
{
    [SerializeField, Header("�G�l�~�[���w��͈͓��ɂ��邩�m�F����X�N���v�g")]
    public EnemyCollision enemyCollision;

    [SerializeField, Header("main Camera")]
    public GameObject mainCamera;

    [SerializeField, Header("pop�������G�l�~�[�����Ԃɓ���郊�X�g")]
    public List<GameObject> popEnemy;

    [SerializeField, Header("�G�l�~�[�|�b�v�Ԃ̑҂�����")]
    public float lateTime = 1.0f;

    //�X�e�[�W�i�s��
    private int stageCount = 0;

    //���b�o��������ۑ�����ϐ�
    private float time = 0.0f;
    
    //���̃|�b�v��������ۑ�����ϐ�
    private int popCount = 0;

    void Start()
    {
        Debug.Log("stage:" + (stageCount + 1));
    }

    // Update is called once per frame
    void Update()
    {
        //�G�l�~�[���|�b�v���ĉ��b�o���������v��
        time += Time.deltaTime;

        //lateTime�ȏ�ɂȂ�������s
        if (time > lateTime)
        {
            //popCount���|�b�v��������s���� else ��
            if (popCount < 10)
            {
                Pop(popEnemy[stageCount], new Vector3(Random.Range(-GlovalValue.xLimit, GlovalValue.xLimit),
                                     Random.Range(0.0f, GlovalValue.yLimit), 0));
                popCount++;
            }
            else
            {
                //�G�l�~�[�����Ȃ��Ȃ�������s
                if (!enemyCollision.IsEnemy())
                {
                    //popEnemy�̃��X�g���ȏ�ɂȂ�������s���Ȃ�
                    if (popEnemy.Count - 1 > stageCount)
                    {
                        //���̃G�l�~�[���|�b�v�ł���悤�ɂ���
                        stageCount += 1;
                        Debug.Log("stage:" + (stageCount + 1));
                        popCount = 0;
                    }
                }
            }
            time = 0;
        }
    }

    //�|�b�v�������I�u�W�F�N�g�Ə����ʒu�̒l����͂�����|�b�v�ł���
    public void Pop(GameObject enemyObject,Vector3 initialPosition)
    {
        //�G�l�~�[�I�u�W�F�N�g����
        GameObject enemyObj1 = Instantiate(enemyObject);
        initialPosition.y += GlovalValue.yLimit * 2;
        //�G�l�~�[�I�u�W�F�N�g�̍��W�ݒ�
        enemyObj1.transform.position = initialPosition;

    }
}
