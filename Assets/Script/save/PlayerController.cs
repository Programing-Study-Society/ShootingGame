/*using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int score;
    public SaveManager saveManager;

    void Update()
    {
        // ���̃X�R�A���Z
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 10;
            Debug.Log("Score: " + score);
        }
    }

    public void SavePlayerData()
    {
        SaveData data = new SaveData
        {
            playerPositionX = transform.position.x,
            playerPositionY = transform.position.y,
            playerPositionZ = transform.position.z,
            score = score,
            items = new List<string> { "Sword", "Shield" } // ���̃f�[�^
        };

        saveManager.Save(data);
    }

    public void LoadPlayerData()
    {
        SaveData data = saveManager.Load();
        if (data != null)
        {
            transform.position = new Vector3(data.playerPositionX, data.playerPositionY, data.playerPositionZ);
            score = data.score;
            Debug.Log("Player Data Loaded!");
        }
    }
}*/

