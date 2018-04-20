using UnityEngine;
using System.Collections.Generic;

public class CrystalMgr
{

    private List<Crystal> crystalList = new List<Crystal>();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RegisterCrystal(Crystal crystal)
    {
        this.crystalList.Add(crystal);
    }

    public Crystal GetNearestCrystal(Vector3 position)
    {
        float minDis = float.MaxValue;
        Crystal rs = null;
        for (int i = 0; i < crystalList.Count; i++)
        {
            float dis = Vector3.Distance(position, crystalList[i].GetPosition());

            if (dis < minDis)
            {
                minDis = dis;
                rs = crystalList[i];
            }
        }
        return rs;
    }
}
