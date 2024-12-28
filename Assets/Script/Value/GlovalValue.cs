using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlovalValue
{
    //難易度 1:easy,2:normal,3:hard,4:master
    public static int Difficulty = 0;
    
    //スコア
    public static int score = 0;

    //ヒットポイント
    public static int HP = 5;
    public static int MaxHP = 5;

    //attack強化値
    public static int attack = 0;
    //アタック強化倍率
    public static float attackMag = 0.100f;
    
    //スピード
    public static float speed = 0.0f;

    
    //アビリティナンバー
    public static int qAvilityNumber = 1;//1,レーザー : 2,ミサイル
    public static int rightClickAvilityNumber = 1;//1,バリア : 2,防御用ボム

    public static int[,] ScoreList = new int[4,5]{
        {0,0,0,0,0},
        {0,0,0,0,0},
        {0,0,0,0,0},
        {0,0,0,0,0}
    };

    //追加
    public static int barrierTime = 0;

    //playerレベル経験値とレベル値
    public static int playerLevelExperience = 0;
    public static int playerLevel = 0;

    //どのくらいステージをクリアしたか
    public static List<bool> firstStageClear = new List<bool>{true,true,true,true};//本来{true,false,false,false};

    //どれだけステータスを振ったか
    public static int addStatasPoint = 0;//ステータスポイント = レベル * 2s

    //音量
    public static float bgmVolume = 0.1f;
    public static float seVolume = 0.25f;

    //保存しなくていいやつ
    public static bool pauseFlag = false;
    public static bool stageclear = false;

    //プレイヤー行動範囲
    public static float xLimit;
    public static float yLimit;

    public static List<int> difficultyEnemyAttack = new List<int>{1,1,2,3};
    public static List<float> difficultyEnemyHP = new List<float>{0.5f,1.0f,1.5f,2.0f};

}
