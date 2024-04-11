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
    // 인벤토리 아이템 등 추가 예정
}

[System.Serializable]
public class World
{
    public short[] map;
    public PlayerData playerData;
}
