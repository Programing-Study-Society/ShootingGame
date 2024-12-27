using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlovalValue
{
    //難易度@1:easy,2:normal,3:hard,4:master
    public static int Difficulty = 0;
    
    //スコア
    public static int score = 0;

    //ヒットポイント
    public static int HP = 20;
    public static int MaxHP = 20;

    //attack強化値
    public static int attack = 0;
    //アタック強化倍率
    public static float attackMag = 0.1f;
    
    //スピード
    public static float speed = 3.0f;

    //プレイヤー行動範囲
    public static float xLimit;
    public static float yLimit;

    //アビリティナンバー
    public static int qAvilityNumber = 2;//1,レーザー : 2,ミサイル
    public static int rightClickAvilityNumber = 1;//1,バリア : 2,防御用ボム

    public static int[,] ScoreList = new int[4,5]{
        {0,1,2,3,4},
        {5,6,7,8,9},
        {10,11,12,13,14},
        {15,16,17,18,19}
    };

    public static bool pauseFlag = false;

    public static int barrierTime = 0;
    

}
