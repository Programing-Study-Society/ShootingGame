using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private string saveFilePath;

    void Start()
    {
        // �Z�[�u�f�[�^�̕ۑ��p�X��ݒ�
        saveFilePath = Path.Combine(Application.persistentDataPath, "savefile.json");
        Debug.Log("Save path: " + saveFilePath);
    }

    // �f�[�^��ۑ�����
    public void Save(SaveData data)
    {
        string json = JsonUtility.ToJson(data, true); // �f�[�^��JSON�ɕϊ�
        File.WriteAllText(saveFilePath, json); // �t�@�C���ɏ�������
        Debug.Log("Data Saved!");
    }

    // �f�[�^��ǂݍ���
    public SaveData Load()
    {
        if (File.Exists(saveFilePath))
        {
            string json = File.ReadAllText(saveFilePath); // �t�@�C����ǂݍ���
            SaveData data = JsonUtility.FromJson<SaveData>(json); // JSON���I�u�W�F�N�g�ɕϊ�
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

