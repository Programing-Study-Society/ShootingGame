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
    public static int speed = 10;

    //�v���C���[�̓�����͈�
    public static float xLimit;
    public static float yLimit;

    //�����A�r���e�B�[�̊Ǘ�
    public static int qAvilityNumber = 2;//1,���[�U�[ : 2,�~�T�C��
    public static int rightClickAvilityNumber = 2;//1,�o���A : 2,�ʏ��Ŕ��e


}
