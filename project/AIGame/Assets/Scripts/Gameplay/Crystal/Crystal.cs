using UnityEngine;
using System.Collections;

public class Crystal : MineralResources
{

    void Awake()
    {
        RegisterSelf();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // 注册自己到水晶管理器里
    private void RegisterSelf()
    {
        GameManager.GetInstance().GetGameSceneMgr().GetCrystalMgr().RegisterCrystal(this);
    }

    // 更新表现
    protected override void UpdateBehaviour()
    {
        base.UpdateBehaviour();

        float currentAmount = GetCurrentAmount();
        if (currentAmount > 0)
        {
            float scale = currentAmount / GetTotalAmount();
            transform.localScale = new Vector3(scale, scale, scale);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
