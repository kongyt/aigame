using UnityEngine;
using System.Collections;

public class Depot : BaseBuilding
{

    // 容量
    public float capacity = 1000;
    
    // 当前量
    public float amount = 0;

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

    public void RegisterSelf() {
        GameManager.GetInstance().GetGameSceneMgr().GetBuildingMgr().RegisterDepot(this);
    }
}
