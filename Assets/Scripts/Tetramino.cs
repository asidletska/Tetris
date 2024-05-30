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
    public Tetramino tetromino;
    public Tile tile;
    public Vector2Int[] cells { get; private set; }

    public void Initialize()
    {
        cells = Data.Cells[this.tetromino];
    }
}

