using UnityEngine;
using UnityEditor;
using System.Collections;

[ExecuteInEditMode]
public class MapMgr : MonoBehaviour {

    public Terrain[,] maps = new Terrain[3, 3];

	// Use this for initialization
	void Start () {
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                string path = "Assets/Resources/Terrains/Terrain" + i + "x" + j + ".asset";
                Debug.Log(path);
                Terrain terrain = (Terrain)AssetDatabase.LoadAssetAtPath(path, typeof(Terrain));
                terrain = (Terrain)GameObject.Instantiate(terrain);


                //GameObject tmp = (GameObject)GameObject.Instantiate());
                maps[i, j] = terrain.GetComponent<Terrain>();
                terrain.transform.parent = transform;
                terrain.transform.position = new Vector3(j * 500, 0, i * 500);
                terrain.transform.rotation = Quaternion.identity;
            }
        }
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
