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
    //???x????@1:easy,2:normal,3:hard,4:master
    public int Difficulty = 1;
    
    //?X?R?A???
    public int score = 0;

    //?v???C???[?X?e?[?^?X
    public int HP = 5;
    public int attack = 1;
    public float speed = 10.0f;

    //?v???C???[?????????
    public float xLimit;
    public float yLimit;

    //????????????
    public int qAvilityNumber = 2;//1,???? : 2,????
    public int rightClickAvilityNumber = 2;//1,??? : 2,?????

    public int[,] ScoreList = new int[4,5]{
        {0,1,2,3,4},
        {5,6,7,8,9},
        {10,11,12,13,14},
        {15,16,17,18,19}
    };
}