using UnityEngine;
using System.Collections;

public class GridBehavior : MonoBehaviour {
    public GameObject Tile;
    public int gridX, gridY;
    private int gridZ = 0;
    public float gridSpacing;
    public string[,] grid;

    void Start()
    {
        createGrid();
    }

    public void createGrid()
    {
        grid = new string[gridX, gridY];
        for (int y = 0; y < gridY; y++)
        {
            for (int x = 0; x < gridX; x++)
            {
                //set cell to empty
                grid[x, y] = "empty";
                //set location of the tile
                Vector3 pos = new Vector3(x, y, gridZ) * gridSpacing;
                //instantiate the tile
                Instantiate(Tile, pos, Quaternion.identity);
            }
        }
    }
}
