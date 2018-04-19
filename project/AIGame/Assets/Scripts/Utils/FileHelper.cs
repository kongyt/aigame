using UnityEngine;
using System.Collections;

public class FileHelper
{
    public static string GetDataPath()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            return Application.streamingAssetsPath + "/Data/";
        }
        else
        {
            return "file://" + Application.streamingAssetsPath + "/Data/";
        }
    }

    public static string GetDataPathInEditMode()
    {
        return Application.dataPath + "/Resources/Data/";
    }
}
