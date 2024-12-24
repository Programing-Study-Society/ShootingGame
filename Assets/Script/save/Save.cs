using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour
{
    [HideInInspector] public SaveData data;     // json???????f?[?^??N???X
    string filePath;                            // json?t?@?C????p?X
    string fileName = "SaveData.json";              // json?t?@?C????
    string metaFileName = "SaveData.json.meta";
    
    // json?????f?[?^????
    void jsonSave(SaveData data)
    {
        InSaveData();
        string json = JsonUtility.ToJson(data);                 // json???????
        StreamWriter wr = new StreamWriter(filePath, false);    // ?t?@?C??????????w??
        wr.Write(json);                                     // json???????????????????
        wr.Flush();
        wr.Close();                                             // ?t?@?C???????
    }

    // json?t?@?C????????
    SaveData Load(string path)
    {
        StreamReader rd = new StreamReader(path);               // ?t?@?C????????w??
        string json = rd.ReadToEnd();                           // ?t?@?C?????e?S???????
        rd.Close();                                             // ?t?@?C???????

        return JsonUtility.FromJson<SaveData>(json);            // json?t?@?C?????^????????
    }

    void Awake()
    {
        filePath = Application.dataPath + "/" + fileName;
    }

    //?X?^?[?g????Json?t?@?C???????l???o???????
    public void StartRoad()
    {
        // ?p?X???��
        filePath = Application.dataPath + "/" + fileName;
        //Debug.Log(filePath);
        // ?t?@?C???????????A?t?@?C????
        if (!File.Exists(filePath))
        {
            jsonSave(data);
        }

        // ?t?@?C?????????? data ??i?[
        data = Load(filePath);

        //?i?[?????l??GlobalValue??i?[
        InGlobalValue();
        Debug.Log(GlovalValue.Difficulty);
    }

    //?Z?[?u
    public void ClickSave()
    {
        // ?Q?[???I????????
        jsonSave(data);
        Debug.Log(filePath);
    }

    //?Z?[?u??????????????n???
    public void ClickReStart()
    {
        JsonFileDelete();
        endGame();
        //StartRoad();
    }

    //?Q?[???I??
    public void endGame()
    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//?Q?[???v???C?I??
#else
        Application.Quit();//?Q?[???v???C?I??
#endif
    }

    //Json?t?@?C??????
    void JsonFileDelete()
    {
        filePath = Application.dataPath + "/" + fileName;
        
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }

        filePath = Application.dataPath + "/" + metaFileName;

        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
        //?V?[????????
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    //public static ?????w????????SaveData????
    public void InSaveData()
    {
        
        data.Difficulty = GlovalValue.Difficulty;
        data.score = GlovalValue.score;
        data.HP= GlovalValue.HP;
        data.attack = GlovalValue.attack;
        data.speed = GlovalValue.speed;
        data.xLimit = GlovalValue.xLimit;
        data.yLimit = GlovalValue.yLimit;
        data.qAvilityNumber = GlovalValue.qAvilityNumber;
        data.rightClickAvilityNumber = GlovalValue.rightClickAvilityNumber;
        data.ScoreList = GlovalValue.ScoreList;
        

        
    }

    //SaveData??l??GlobalValue????
    public void InGlobalValue()
    {

        GlovalValue.Difficulty=data.Difficulty;
        GlovalValue.score=data.score;
        GlovalValue.HP=data.HP;
        GlovalValue.attack=data.attack;
        GlovalValue.speed=data.speed;
        GlovalValue.xLimit=data.xLimit;
        GlovalValue.yLimit=data.yLimit;
        GlovalValue.qAvilityNumber=data.qAvilityNumber;
        GlovalValue.rightClickAvilityNumber=data.rightClickAvilityNumber;
        GlovalValue.ScoreList=data.ScoreList;

        
    }
}
