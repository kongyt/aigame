using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class CatapultBehaviour : MonoBehaviour {

    private ColorType lastColorType;
    public ColorType colorType;


    private bool lastShowRock;
    public bool showRock;

    [Space(20)]
    public RuntimeAnimatorController catapultAnimatorController;

    [Space(20)]
    public Material black;
    public Material blue;
    public Material brown;
    public Material green;
    public Material purple;
    public Material red;
    public Material tan;
    public Material white;

    [Space(20)]
    public SkinnedMeshRenderer catapult;
    public MeshRenderer rock;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (lastColorType != colorType)
        {
            SetColorType(colorType);
        }

        if (lastShowRock != showRock) {
            SetShowRock(showRock);
        }
	}

    public void SetColorType(ColorType type)
    {
        this.lastColorType = type;
        Material mat = null;
        switch (type)
        {
            case ColorType.Black:
                mat = black;
                break;
            case ColorType.Blue:
                mat = blue;
                break;
            case ColorType.Brown:
                mat = brown;
                break;
            case ColorType.Green:
                mat = green;
                break;
            case ColorType.Purple:
                mat = purple;
                break;
            case ColorType.Red:
                mat = red;
                break;
            case ColorType.Tan:
                mat = tan;
                break;
            case ColorType.White:
                mat = white;
                break;
        }
        if (mat != null)
        {
            catapult.material = mat;
            rock.material = mat;
           
        }
    }


    public void SetShowRock(bool show) {
        this.lastShowRock = show;
        if (show)
        {
            rock.gameObject.SetActive(true);
        }
        else {
            rock.gameObject.SetActive(false);
        }
    }
}
