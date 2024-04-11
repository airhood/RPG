using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string playerName;
    public Vector2 playerPosition;
    public short health;
    public byte hotBarIndex;
    // �κ��丮 ������ �� �߰� ����
}

[System.Serializable]
public class World
{
    public short[] map;
    public PlayerData playerData;
}
