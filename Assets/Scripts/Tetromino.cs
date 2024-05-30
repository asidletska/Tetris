using System;
using UnityEngine;
using UnityEngine.Tilemaps;

public enum Tetramino
{
    I,
    O,
    T,
    J,
    L,
    S,
    Z,
}
[Serializable]
public struct TetraminoData
{
    public Tetramino tetramino;
    public Tile tile;
    public Vector2Int[] cells;
}
