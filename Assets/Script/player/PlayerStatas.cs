using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatas : MonoBehaviour
{
    [SerializeField, Header("�v���C���[��HP")]
    public int HP;
    [SerializeField, Header("�v���C���[�̍U����")]
    public int ATK;
    [SerializeField, Header("�v���C���[�̑��x")]
    public float SPD;

    // Start is called before the first frame update
    void Start()
    {
        HP = GlovalValue.HP;
        ATK = GlovalValue.attack;
        SPD = GlovalValue.speed;
    }
}
