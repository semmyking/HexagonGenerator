using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonGenerator : MonoBehaviour
{

    public int mapWidth = 25;
    public int mapHeight = 12;

    public float TileXOffset = 1.8f;
    public float TileZOffset = 1.6f;

    public GameObject Hexagon;

    // Start is called before the first frame update
    void Start()
    {
        CreateHexTileMap();
    }


    void CreateHexTileMap()
    {
        for (int x = 0; x <= mapWidth; x++)
        {
            for (int z = 0; z <= mapHeight; z++)
            {
                GameObject Hexagons = Instantiate(Hexagon);
                if (z % 2 == 0)
                {
                    Hexagons.transform.position = new Vector3(x * TileXOffset, 0, z * TileZOffset);
                }
                else
                {
                    Hexagons.transform.position = new Vector3(x * TileXOffset + TileXOffset / 2, 0, z * TileZOffset);
                }
                SetTileInfo(Hexagons,  x, z);
            }
        }
    }

    void SetTileInfo(GameObject gameobject, int x, int z)
    {
        gameobject.transform.parent = transform;
        gameobject.name = x.ToString() + ", " + z.ToString();
    }
}
