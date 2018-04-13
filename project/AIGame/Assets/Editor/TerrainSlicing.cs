using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;
using System.Collections.Generic;

public class TerrainSlicing : Editor {
    public static string TerrainSavePath = "Assets/Resources/Terrains";

    // 分割大小
    public static int SLICING_SIZE = 4;

    [MenuItem("Terrain/Slicing")]
    private static void Slicing() {
        Terrain terrain = GameObject.FindObjectOfType<Terrain>();
        if (terrain == null) {
            return;
        }

        if (Directory.Exists(TerrainSavePath))
        {
            Directory.Delete(TerrainSavePath, true);
        }
        Directory.CreateDirectory(TerrainSavePath);

        TerrainData terrainData = terrain.terrainData;

        Vector3 oldSize = terrainData.size;


        // 得到新地图分辨率
        int newHeightmapResolution = (terrainData.heightmapResolution - 1) / SLICING_SIZE;
        int newAlphamapResolution = terrainData.alphamapResolution / SLICING_SIZE;
        int newbaseMapResolution = terrainData.baseMapResolution / SLICING_SIZE;
        SplatPrototype[] splatProtos = terrainData.splatPrototypes;

        // 生成小地形块
        for (int x = 0; x < SLICING_SIZE; x++) {
            for (int y = 0; y < SLICING_SIZE; y++) { 
                // 创建资源
                TerrainData newData = new TerrainData();
                string terrainName = TerrainSavePath + "/Terrain"+ y + "x"+ x + ".asset";
                AssetDatabase.CreateAsset(newData, terrainName);
                EditorUtility.DisplayProgressBar("正在分割地形", terrainName, (float)(x * SLICING_SIZE + y) / (float)(SLICING_SIZE * SLICING_SIZE));

                // 设置分辨率
                newData.heightmapResolution = newHeightmapResolution;
                newData.alphamapResolution = newAlphamapResolution;
                newData.baseMapResolution = newbaseMapResolution;

                // 设置大小
                newData.size = new Vector3(oldSize.x / SLICING_SIZE, oldSize.y, oldSize.z/SLICING_SIZE);
            
                // 设置地形原型
                SplatPrototype[] newSplats = new SplatPrototype[splatProtos.Length];
                for (int i = 0; i < splatProtos.Length; i++) {
                    newSplats[i] = new SplatPrototype();
                    newSplats[i].texture = splatProtos[i].texture;
                    newSplats[i].tileSize = splatProtos[i].tileSize;

                    float offsetX = (newData.size.x * x) % splatProtos[i].tileSize.x + splatProtos[i].tileOffset.x;
                    float offsetY = (newData.size.z * y) % splatProtos[i].tileSize.y + splatProtos[i].tileOffset.y;
                    newSplats[i].tileOffset = new Vector2(offsetX, offsetY);
                }
                newData.splatPrototypes = newSplats;

                // 设置混合贴图
                //float[, ,] alphamap = new float[newAlphamapResolution, newAlphamapResolution, splatProtos.Length];
                float[, ,] alphamap = terrainData.GetAlphamaps(x * newData.alphamapWidth, y * newData.alphamapHeight, newData.alphamapWidth, newData.alphamapHeight);
                newData.SetAlphamaps(0, 0, alphamap);

                // 设置高度
                int xBase = terrainData.heightmapWidth / SLICING_SIZE;
                int yBase = terrainData.heightmapHeight / SLICING_SIZE;
                float[,] heights = terrainData.GetHeights(xBase * x, yBase * y, xBase + 1, yBase + 1);
                newData.SetHeights(0, 0, heights);

                newData.treePrototypes = terrainData.treePrototypes;

                TreeInstance[] trees = terrainData.treeInstances;

                List<TreeInstance> treeInNewMap = new List<TreeInstance>();

                Vector3 newTerrainPos = new Vector3(newData.size.x * x, newData.size.y, newData.size.z * y);
 
                for(int i = 0;i < trees.Length; i++){
                    Vector3 newPos = Vector3.Scale(trees[i].position, terrainData.size) + terrain.transform.position;
                    Vector2 pos = new Vector2(newPos.x, newPos.z);
    

                    if(IsInBox(pos, xBase * x, yBase * y, xBase, yBase)){
                        TreeInstance newTree = new TreeInstance();
                        newTree.position = Vector3.Scale((newPos - newTerrainPos), new Vector3(1/newData.size.x, 1/ newData.size.y, 1/newData.size.z));
                        newTree.heightScale = trees[i].heightScale;
                        newTree.widthScale = trees[i].widthScale;
                        newTree.lightmapColor = trees[i].lightmapColor;
                        newTree.color = trees[i].color;
                        newTree.prototypeIndex = trees[i].prototypeIndex;
                        treeInNewMap.Add(newTree);
                        Debug.Log("添加Tree");
                    }
                }
                newData.treeInstances = treeInNewMap.ToArray();
            }
        }

        for (int i = 0; i < terrainData.treeInstances.Length; i++) { 
            
        }

            EditorUtility.ClearProgressBar();
    }

    public static bool IsInBox(Vector2 position, float x, float y, float width, float height) {
        if (position.x >= x && position.x < x + width && position.y >= y && position.y < y + height)
        {
            return true;
        }
        else {
            return false;
        }
    }
	
}
