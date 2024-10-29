using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlovalValue
{
    //難易度変数　1:easy,2:normal,3:hard,4:master
    public static int Difficulty = 1;
    
    //スコア変数
    public static int score = 0;

    //プレイヤーステータス
    public static int HP = 5;
    public static int attack = 1;

    //プレイヤーの動ける範囲
    public static float xLimit;
    public static float yLimit;


}
