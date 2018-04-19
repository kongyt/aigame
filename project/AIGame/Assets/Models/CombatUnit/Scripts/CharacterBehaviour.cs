using UnityEngine;
using System.Collections;


[ExecuteInEditMode]
public class CharacterBehaviour : MonoBehaviour {

    private CharacterType lastCharacterType;
    public CharacterType characterType;

    private ColorType lastColorType;
    public ColorType colorType;

    private HeadType lastHeadType;
    public HeadType headType;

    private BodyType lastBodyType;
    public BodyType bodyType;

    private ArmType lastArmType;
    public ArmType armType;

    private LegType lastLegType;
    public LegType legType;

    private LHandType lastLHandType;
    public LHandType lHandType;

    private RHandType lastRHandType;
    public RHandType rHandType;

    private ShoulderpadsType lastShoulderpadsType;
    public ShoulderpadsType shoulderpadsType;

    private bool lastHasBag;
    public bool hasBag;

    private bool lastHasWood;
    public bool hasWood;

    private bool lastHasQuiver;
    public bool hasQuiver;

    [Space(20)]
    public GameObject animatorOwner;

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
    public RuntimeAnimatorController archerAnimatorController;
    public RuntimeAnimatorController infantryAnimatorController;
    public RuntimeAnimatorController mageAnimatorController;
    public RuntimeAnimatorController spearmanAnimatorController;
    public RuntimeAnimatorController workerAnimatorController;

    [Space(20)]
    public SkinnedMeshRenderer arms_A;
    public SkinnedMeshRenderer arms_B;
    public SkinnedMeshRenderer arms_C;
    public SkinnedMeshRenderer arms_D;

    [Space(20)]
    public SkinnedMeshRenderer body_A;
    public SkinnedMeshRenderer body_B;
    public SkinnedMeshRenderer body_C;
    public SkinnedMeshRenderer body_D;
    public SkinnedMeshRenderer body_E;

    [Space(20)]
    public SkinnedMeshRenderer head_A;
    public SkinnedMeshRenderer head_B;
    public SkinnedMeshRenderer head_C;
    public SkinnedMeshRenderer head_D;
    public SkinnedMeshRenderer head_E;
    public SkinnedMeshRenderer head_F;
    public SkinnedMeshRenderer head_G;
    public SkinnedMeshRenderer head_H;
    public SkinnedMeshRenderer head_I;

    [Space(20)]
    public SkinnedMeshRenderer legs_A;
    public SkinnedMeshRenderer legs_B;
    public SkinnedMeshRenderer legs_C;

    [Space(20)]
    public SkinnedMeshRenderer shoulderpads_A;
    public SkinnedMeshRenderer shoulderpads_B;

    [Space(20)]
    public MeshRenderer r_Axe_A;
    public MeshRenderer r_Axe_B;
    public MeshRenderer r_Hammer_A;
    public MeshRenderer r_Hammer_B;
    public MeshRenderer r_Pick;
    public MeshRenderer r_Spear;
    public MeshRenderer r_Sword_A;
    public MeshRenderer r_Sword_B;

    [Space(20)]
    public MeshRenderer l_Bow;
    public MeshRenderer l_Shield_A;
    public MeshRenderer l_Shield_B;
    public MeshRenderer l_Shield_C;
    public MeshRenderer l_Shield_D;
    public MeshRenderer l_Staff_A;
    public MeshRenderer l_Staff_B;
    public MeshRenderer l_Staff_C;

    [Space(20)]
    public MeshRenderer bag;
    public MeshRenderer wood;
    public MeshRenderer quiver;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (lastCharacterType != characterType) {
            SetCharacterType(characterType);
        }

        if (lastColorType != colorType) {
            SetColorType(colorType);
        }

        if (lastHeadType != headType)
        {
            SetHeadType(headType);
        }

        if (lastBodyType != bodyType)
        {
            SetBodyType(bodyType);
        }

        if (lastArmType != armType)
        {
            SetArmType(armType);
        }

        if (lastLegType != legType)
        {
            SetLegType(legType);
        }

        if (lastLHandType != lHandType)
        {
            SetLHandType(lHandType);
        }

        if (lastRHandType != rHandType)
        {
            SetRHandType(rHandType);
        }

        if (lastShoulderpadsType != shoulderpadsType)
        {
            SetShoulderpadsType(shoulderpadsType);
        }

        if (lastHasBag != hasBag)
        {
            SetHasBag(hasBag);
        }

        if (lastHasWood != hasWood)
        {
            SetHasWood(hasWood);
        }

        if (lastHasQuiver != hasQuiver)
        {
            SetHasQuiver(hasQuiver);
        }
	}

    public void SetCharacterType(CharacterType type) {
        this.lastCharacterType = type;
        RuntimeAnimatorController tmp = null;
        switch (type) { 
            case CharacterType.Archer:
                tmp = archerAnimatorController;
                break;
            case CharacterType.Infantry:
                tmp = infantryAnimatorController;
                break;
            case CharacterType.Mage:
                tmp = mageAnimatorController;
                break;
            case CharacterType.Spearman:
                tmp = spearmanAnimatorController;
                break;
            case CharacterType.Worker:
                tmp = workerAnimatorController;
                break;
        }

        animatorOwner.GetComponent<Animator>().runtimeAnimatorController = tmp;    
    }

    public void SetColorType(ColorType type) {
        this.lastColorType = type;
        Material mat = null;
        switch (type) { 
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
        if (mat != null) {

            arms_A.material = mat;
            arms_B.material = mat;
            arms_C.material = mat;
            arms_D.material = mat;


            body_A.material = mat;
            body_B.material = mat;
            body_C.material = mat;
            body_D.material = mat;
            body_E.material = mat;


            head_A.material = mat;
            head_B.material = mat;
            head_C.material = mat;
            head_D.material = mat;
            head_E.material = mat;
            head_F.material = mat;
            head_G.material = mat;
            head_H.material = mat;
            head_I.material = mat;


            legs_A.material = mat;
            legs_B.material = mat;
            legs_C.material = mat;


            shoulderpads_A.material = mat;
            shoulderpads_B.material = mat;


            r_Axe_A.material = mat;
            r_Axe_B.material = mat;
            r_Hammer_A.material = mat;
            r_Hammer_B.material = mat;
            r_Pick.material = mat;
            r_Spear.material = mat;
            r_Sword_A.material = mat;
            r_Sword_B.material = mat;


            l_Bow.material = mat;
            l_Shield_A.material = mat;
            l_Shield_B.material = mat;
            l_Shield_C.material = mat;
            l_Shield_D.material = mat;
            l_Staff_A.material = mat;
            l_Staff_B.material = mat;
            l_Staff_C.material = mat;


            bag.material = mat;
            wood.material = mat;
            quiver.material = mat;
        }
    }

    // 设置头类型
    public void SetHeadType(HeadType type)
    {
        this.lastHeadType = type;
        head_A.gameObject.SetActive(false);
        head_B.gameObject.SetActive(false);
        head_C.gameObject.SetActive(false);
        head_D.gameObject.SetActive(false);
        head_E.gameObject.SetActive(false);
        head_F.gameObject.SetActive(false);
        head_G.gameObject.SetActive(false);
        head_H.gameObject.SetActive(false);
        head_I.gameObject.SetActive(false);
        switch (type)
        {
            case HeadType.A:
                head_A.gameObject.SetActive(true);
                break;
            case HeadType.B:
                head_B.gameObject.SetActive(true);
                break;
            case HeadType.C:
                head_C.gameObject.SetActive(true);
                break;
            case HeadType.D:
                head_D.gameObject.SetActive(true);
                break;
            case HeadType.E:
                head_E.gameObject.SetActive(true);
                break;
            case HeadType.F:
                head_F.gameObject.SetActive(true);
                break;
            case HeadType.G:
                head_G.gameObject.SetActive(true);
                break;
            case HeadType.H:
                head_H.gameObject.SetActive(true);
                break;
            case HeadType.I:
                head_I.gameObject.SetActive(true);
                break;
        }
    }

    // 设置身体类型
    public void SetBodyType(BodyType type)
    {
        this.lastBodyType = type;
        body_A.gameObject.SetActive(false);
        body_B.gameObject.SetActive(false);
        body_C.gameObject.SetActive(false);
        body_D.gameObject.SetActive(false);
        body_E.gameObject.SetActive(false);
        switch (type)
        {
            case BodyType.A:
                body_A.gameObject.SetActive(true);
                break;
            case BodyType.B:
                body_B.gameObject.SetActive(true);
                break;
            case BodyType.C:
                body_C.gameObject.SetActive(true);
                break;
            case BodyType.D:
                body_D.gameObject.SetActive(true);
                break;
            case BodyType.E:
                body_E.gameObject.SetActive(true);
                break;
        }
    }

    // 设置胳膊类型
    public void SetArmType(ArmType type)
    {
        this.lastArmType = type;
        arms_A.gameObject.SetActive(false);
        arms_B.gameObject.SetActive(false);
        arms_C.gameObject.SetActive(false);
        arms_D.gameObject.SetActive(false);
        switch (type)
        {
            case ArmType.A:
                arms_A.gameObject.SetActive(true);
                break;
            case ArmType.B:
                arms_B.gameObject.SetActive(true);
                break;
            case ArmType.C:
                arms_C.gameObject.SetActive(true);
                break;
            case ArmType.D:
                arms_D.gameObject.SetActive(true);
                break;
        }
    }

    // 设置腿类型
    public void SetLegType(LegType type)
    {
        this.lastLegType = type;
        legs_A.gameObject.SetActive(false);
        legs_B.gameObject.SetActive(false);
        legs_C.gameObject.SetActive(false);
        switch (type)
        {
            case LegType.A:
                legs_A.gameObject.SetActive(true);
                break;
            case LegType.B:
                legs_B.gameObject.SetActive(true);
                break;
            case LegType.C:
                legs_C.gameObject.SetActive(true);
                break;
        }
    }


    // 设置左手类型
    public void SetLHandType(LHandType type) {
        this.lastLHandType = type;
        l_Bow.gameObject.SetActive(false);
        l_Shield_A.gameObject.SetActive(false);
        l_Shield_B.gameObject.SetActive(false);
        l_Shield_C.gameObject.SetActive(false);
        l_Shield_D.gameObject.SetActive(false);
        l_Staff_A.gameObject.SetActive(false);
        l_Staff_B.gameObject.SetActive(false);
        l_Staff_C.gameObject.SetActive(false);
        switch (type) { 
            case LHandType.Bow:
                l_Bow.gameObject.SetActive(true);
                break;
            case LHandType.Shield_A:
                l_Shield_A.gameObject.SetActive(true);
                break;
            case LHandType.Shield_B:
                l_Shield_B.gameObject.SetActive(true);
                break;
            case LHandType.Shield_C:
                l_Shield_C.gameObject.SetActive(true);
                break;
            case LHandType.Shield_D:
                l_Shield_D.gameObject.SetActive(true);
                break;
            case LHandType.Staff_A:
                l_Staff_A.gameObject.SetActive(true);
                break;
            case LHandType.Staff_B:
                l_Staff_B.gameObject.SetActive(true);
                break;
            case LHandType.Staff_C:
                l_Staff_C.gameObject.SetActive(true);
                break;
        }
       
    }

    // 设置右手类型
    public void SetRHandType(RHandType type) {
        this.lastRHandType = type;
        r_Axe_A.gameObject.SetActive(false);
        r_Axe_B.gameObject.SetActive(false);
        r_Hammer_A.gameObject.SetActive(false);
        r_Hammer_B.gameObject.SetActive(false);
        r_Spear.gameObject.SetActive(false);
        r_Pick.gameObject.SetActive(false);
        r_Sword_A.gameObject.SetActive(false);
        r_Sword_B.gameObject.SetActive(false);
        switch (type)
        {
            case RHandType.Axe_A:
                r_Axe_A.gameObject.SetActive(true);
                break;
            case RHandType.Axe_B:
                r_Axe_B.gameObject.SetActive(true);
                break;
            case RHandType.Hammer_A:
                r_Hammer_A.gameObject.SetActive(true);
                break;
            case RHandType.Hammer_B:
                r_Hammer_B.gameObject.SetActive(true);
                break;
            case RHandType.Spear:
                r_Spear.gameObject.SetActive(true);
                break;
            case RHandType.Pick:
                r_Pick.gameObject.SetActive(true);
                break;
            case RHandType.Sword_A:
                r_Sword_A.gameObject.SetActive(true);
                break;
            case RHandType.Sword_B:
                r_Sword_B.gameObject.SetActive(true);
                break;
        }
    }

    // 设置右手类型
    public void SetShoulderpadsType(ShoulderpadsType type)
    {
        this.lastShoulderpadsType = type;
        this.shoulderpads_A.gameObject.SetActive(false);
        this.shoulderpads_B.gameObject.SetActive(false);
        switch (type)
        {
            case ShoulderpadsType.A:
                shoulderpads_A.gameObject.SetActive(true);
                break;
            case ShoulderpadsType.B:
                shoulderpads_B.gameObject.SetActive(true);
                break;
        }
    }

    public void SetHasBag(bool has) {
        lastHasBag = has;
        if (lastHasBag)
        {
            bag.gameObject.SetActive(true);
        }
        else {
            bag.gameObject.SetActive(false);
        }
    }

    public void SetHasWood(bool has)
    {
        lastHasWood = has;
        if (lastHasWood)
        {
            wood.gameObject.SetActive(true);
        }
        else
        {
            wood.gameObject.SetActive(false);
        }
    }

    public void SetHasQuiver(bool has)
    {
        lastHasQuiver = has;
        if (lastHasQuiver)
        {
            quiver.gameObject.SetActive(true);
        }
        else
        {
            quiver.gameObject.SetActive(false);
        }
    }

}
