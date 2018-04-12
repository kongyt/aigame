using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour {

    public const int TiledSizeX = 10;
    public const int TiledSizeZ = 10;
    public const int TiledLength = 1000;
    public const int TiledWidth = 1000;
    public const int TiledHeight = 256;

    public Terrain terr;

    public Terrain[,] maps = new Terrain[TiledSizeX, TiledSizeZ];

	// Use this for initialization
	void Start () {
        terr.terrainData = new TerrainData();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
