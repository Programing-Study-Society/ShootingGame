using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlovalValue
{
    //��Փx�ϐ��@1:easy,2:normal,3:hard,4:master
    public static int Difficulty = 1;
    
    //�X�R�A�ϐ�
    public static int score = 0;

    //�v���C���[�X�e�[�^�X
    public static int HP = 5;
    public static int attack = 1;

    //�v���C���[�̓�����͈�
    public static float xLimit;
    public static float yLimit;

    public static int[,] ScoreList = new int[4,5]{
        {0,1,2,3,4},
        {5,6,7,8,9},
        {10,11,12,13,14},
        {15,16,17,18,19}
    };
    
}
