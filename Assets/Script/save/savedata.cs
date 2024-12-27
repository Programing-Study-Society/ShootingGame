using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectData
{
    public List<int> originalID = new List<int>();
    public List<int> objID = new List<int>();
    public List<Vector3> pos = new List<Vector3>();
}

[System.Serializable]
public class SaveData
{
    //難易度 1:easy,2:normal,3:hard,4:master
    public int Difficulty = 0;
    
    //スコア
    public int score = 0;

    //ヒットポイント
    public int HP = 5;
    public int MaxHP = 5;

    //attack強化値
    public int attack = 0;
    //アタック強化倍率
    public float attackMag = 0.100f;
    
    //スピード
    public float speed = 0.0f;

    

    //アビリティナンバー
    public int qAvilityNumber = 1;//1,レーザー : 2,ミサイル
    public int rightClickAvilityNumber = 1;//1,バリア : 2,防御用ボム

    public List<int> ScoreList = new List<int>{ 0,0,0,0,0,
                                                0,0,0,0,0,
                                                0,0,0,0,0,
                                                0,0,0,0,0};

    public int barrierTime = 0;

    //playerレベル経験値とレベル値
    public int playerLevelExperience = 0;
    public int playerLevel = 0;

    public List<bool> firstStageClear = new List<bool>{true,false,false,false};

    //どれだけステータスを振ったか
    public int addStatasPoint = 0;//ステータスポイント = レベル * 2s
}