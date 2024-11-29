using System.Collections.Generic;

[System.Serializable] // JSON変換可能にするための属性
public class SaveData
{
    public float playerPositionX;
    public float playerPositionY;
    public float playerPositionZ;
    public int score;
    public List<string>items; // 所持アイテムのリスト
}