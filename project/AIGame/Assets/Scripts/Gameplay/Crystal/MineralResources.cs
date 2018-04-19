using UnityEngine;
using System.Collections;

/// <summary>
/// 矿产资源基类
/// </summary>
public abstract class MineralResources : MonoBehaviour {

    // 矿产资源总量
    public int totalAmount = 1000;
    
    // 当前资源量
    public int currentAmount = 1000;

    // 取走一定数量的矿产资源，成功返回true，失败返回false
    public bool Take(int amount) {
        if (currentAmount >= amount)
        {
            currentAmount -= amount;
            UpdateBehaviour();
            return true;
        }
        else {
            return false;
        }
    }

    // 获取当前资源量
    public int GetCurrentAmount() {
        return currentAmount;
    }

    // 返回资源总量
    public int GetTotalAmount() {
        return totalAmount;
    }

    // 返回资源位置
    public Vector3 GetPosition() {
        return transform.position;
    }

    protected virtual void UpdateBehaviour() { 
    
    }
}
