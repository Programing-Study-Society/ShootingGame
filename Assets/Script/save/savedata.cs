using System.Collections.Generic;

[System.Serializable] // JSON�ϊ��\�ɂ��邽�߂̑���
public class SaveData
{
    public float playerPositionX;
    public float playerPositionY;
    public float playerPositionZ;
    public int score;
    public List<string>items; // �����A�C�e���̃��X�g
}