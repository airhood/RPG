using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public enum Rotation
{
    East, West, South, North
}

public class TerrainManager : MonoBehaviour
{
    [Header("World Tilemaps")]
    [SerializeField] private Tilemap ground_tilemap;
    [SerializeField] private Tilemap construction_tilemap;

    public bool SetBlock(Vector2Int position, short blockID, Rotation rotation)
    {
        return true;
    }
}