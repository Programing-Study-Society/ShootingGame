using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private string saveFilePath;

    void Start()
    {
        // セーブデータの保存パスを設定
        saveFilePath = Path.Combine(Application.persistentDataPath, "savefile.json");
        Debug.Log("Save path: " + saveFilePath);
    }

    // データを保存する
    public void Save(SaveData data)
    {
        string json = JsonUtility.ToJson(data, true); // データをJSONに変換
        File.WriteAllText(saveFilePath, json); // ファイルに書き込む
        Debug.Log("Data Saved!");
    }

    // データを読み込む
    public SaveData Load()
    {
        if (File.Exists(saveFilePath))
        {
            string json = File.ReadAllText(saveFilePath); // ファイルを読み込む
            SaveData data = JsonUtility.FromJson<SaveData>(json); // JSONをオブジェクトに変換
            Debug.Log("Data Loaded!");
            return data;
        }
        else
        {
            Debug.LogWarning("No save file found!");
            return null;
        }
    }
}

