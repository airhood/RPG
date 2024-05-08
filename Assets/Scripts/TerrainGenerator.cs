using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class TerrainGenerator : MonoBehaviour
{
    [SerializeField] private Texture2D texture;

    [Header("World Settings")]
    public Vector2Int worldSize;

    [Header("World Managers")]
    [SerializeField] private TerrainManager terrainManager;
    
    // Start is called before the first frame update
    void Start()
    {
        texture = new Texture2D(worldSize.x, worldSize.y);
        GenerateWorld();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int[,,] GenerateWorld()
    {
        int[,,] map = new int[2, worldSize.x, worldSize.y];
        int[,] landMap = GenerateLandMap();

        for (int x = 0; x < worldSize.x; x++)
        {
            for (int y = 0; y < worldSize.y; y++)
            {
                if (landMap[x, y] != 1) continue;
                
            }
        }
        
        return map;
    }

    private int[,] GenerateLandMap()
    {
        string seed = Time.time.ToString();
        System.Random random = new System.Random(seed.GetHashCode());
        float[,] noise = Noise.GenerateNoiseMap(worldSize.x, worldSize.y, 1, random.Next(0, int.MaxValue),
            5, 0.5f, 2, new Vector2(0, 0));
        int[,] landMap = new int[worldSize.x, worldSize.y];

        for (int x = 0; x < worldSize.x; x++)
        {
            for (int y = 0; y < worldSize.y; y++)
            {
                if (noise[x, y] < 0.5f)
                {
                    landMap[x, y] = 2;
                    texture.SetPixel(x, y, Color.black);
                }
                else
                {
                    landMap[x, y] = 1;
                    texture.SetPixel(x, y, Color.white);
                }
            }
        }
        
        texture.Apply();
        
        return landMap;
    }
}
