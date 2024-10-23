using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPop : MonoBehaviour
{
    public List<GameObject> popEnemy;

    public float lateTime = 1.0f;
    float time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time <= lateTime)
            return;
        Pop(popEnemy[0], new Vector3(0, 0, 0));
        time = 0;

    }

    //�|�b�v�������I�u�W�F�N�g�Ə����ʒu�̒l����͂�����|�b�v�ł���
    public void Pop(GameObject enemyObject,Vector3 initialPosition)
    {
        //�G�l�~�[�I�u�W�F�N�g����
        GameObject enemyObj1 = Instantiate(enemyObject);

        //�G�l�~�[�I�u�W�F�N�g�̍��W�ݒ�
        enemyObj1.transform.position = initialPosition;

    }
}
