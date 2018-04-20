using UnityEngine;
using System.Collections;


public class BaseBuilding : MonoBehaviour {

    public int costMoney;
    public float costTime;
    public float buildSpeed = 1;
    public int totalHP = 100;
    public int currentHP = 0;
    private bool isBuilding = false;

    private float hp = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (isBuilding) {
            BuildStep();
            UpdateBehaviour();
        }
	}

    

    // 建造
    public void Build() {
        isBuilding = true;
    }


    // 修复
    public void Repair() { 
    
    }

    // 销毁
    public void Destroy() { 
    
    }

    //
    public virtual void BuildStep()
    {
        hp += buildSpeed * (totalHP / costTime) * Time.deltaTime;
        if (hp >= totalHP) {
            isBuilding = false;
        }
        currentHP = (int)hp;
    }

    // 更新表现
    public virtual void UpdateBehaviour() { 
        
    }

    public Vector3 GetPosition() {
        return transform.position;
    }
}
