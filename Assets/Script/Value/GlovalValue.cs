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
    public static int speed = 10;

    //プレイヤーの動ける範囲
    public static float xLimit;
    public static float yLimit;

    //武器やアビリティーの管理
    public static int qAvilityNumber = 2;//1,レーザー : 2,ミサイル
    public static int rightClickAvilityNumber = 2;//1,バリア : 2,玉消滅爆弾


}
