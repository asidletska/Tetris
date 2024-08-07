using System;
using UnityEngine;
using UnityEngine.Tilemaps;

public enum Tetromino
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
public struct TetrominoData
{
    public Tetromino tetramino;
    public Tile tile;
    public Vector2Int[] cells { get; private set; }
    public Vector2Int[,] wallKicks { get; private set; }

    public void Initialize()
    {
        cells = Data.Cells[tetramino];
        wallKicks = Data.WallKicks[tetramino];
    }

}
