
using System.Collections.Generic;
using _Scripts;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public int row;
    public int column;
    public GameObject _tilePrefab;
    private List<Tile> _tiles;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _tiles = new List<Tile>(row * column);

        for (int x = 0; x < column; x++)
        {
            for (int y = 0; y < row; y++)
            {
                Tile tile = GameObject.Instantiate(_tilePrefab, FindPosition(x, y), Quaternion.identity, transform).GetComponent<Tile>();
                tile.Initialize(x,y);
                tile.gameObject.name = "Tile " + x + ", " + y;
                _tiles.Add(tile);
            }
        }
        
        Camera.main.transform.position = _tiles[_tiles.Count / 2].transform.position;
        Camera.main.transform.position -= 10 * Vector3.forward;
    }

    private Vector3 FindPosition(int x, int y)
    {
        float xOffset = (float)column / 2f;
        float yOffset = (float)row / 2f;
        return new Vector3(x*1.1f - xOffset, y*1.1f - yOffset, 0);
    }
    
    public Tile GetTile (int x, int y)
    {
        foreach (var tile in _tiles)
        {
            if (x == tile.x && y == tile.y)
            {
                return tile;
            }
        }
        return null;
    }
}