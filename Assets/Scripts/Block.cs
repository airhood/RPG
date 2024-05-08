using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public enum BlockType
{
    Ground, Construction
}

public enum BlockRotationSetting
{
    All, Horizontal, Vertical, None
}

[System.Serializable]
public struct TilePiece
{
    public Vector2Int position;
    public RuleTile tile;
}

[System.Serializable]
public struct TileVariant
{
    public string varientName;
    public List<TilePiece> tiles;
}

[CreateAssetMenu(menuName = "World/Block", fileName = "new Block", order = 0)]
public class Block : ScriptableObject
{
    [Header("Info")]
    public short id;
    public string name;
    public string description;
    public BlockType blockType;

    [Header("Tile Data")]
    public byte defaultVariant;
    public List<TileVariant> tileVariants;

    [Header("Construction Data")]
    public BlockRotationSetting rotationSetting;
    public Texture constructionTexture;
    public GameObject ui;

    [Header("Relation Data")]
    public short itemID;
}