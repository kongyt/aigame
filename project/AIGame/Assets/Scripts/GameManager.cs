using UnityEngine;
using System.Collections;

public class GameManager : SingletonDontDestroy<GameManager> {

    // 游戏场景管理，游戏场景里的所有物体皆由此类管理
    private GameSceneMgr gameSceneMgr;

	// Use this for initialization
	void Start () {
        if (Application.loadedLevelName.Equals(SceneDefine.GetSceneNameById(SceneDefine.MAIN_SCENE))) {
            this.ChangeScene(SceneDefine.GAME_SCENE);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //----------------
    // Common function
    public void ChangeScene(int sceneId) {
        string sceneName = SceneDefine.GetSceneNameById(sceneId);
        if(sceneName != null){
            Application.LoadLevel(sceneName);
        }
    }

    //-----------------

    public GameSceneMgr GetGameSceneMgr()
    {
        if (gameSceneMgr == null)
        {
            gameSceneMgr = new GameSceneMgr();
        }
        return gameSceneMgr;
    }
}
