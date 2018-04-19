using UnityEngine;
using System.Collections;

public class SceneDefine {

    private static string[] SceneNames = 
    {
        "MainScene",
        "MenuScene",
        "GameScene",                      
    };
    
    public const int MAIN_SCENE = 0;
    public const int MENU_SCENE = 1;
    public const int GAME_SCENE = 2;

    private const int MAX_SCENE_ID = 2;

    public static string GetSceneNameById(int sceneId) {
        if (sceneId < 0 || sceneId > MAX_SCENE_ID)
        {
            return null;
        }
        else {
            return SceneNames[sceneId];
        }
    }

}
