using UnityEngine;
using System.Collections.Generic;

public class BuildingMgr
{

    private List<Depot> allDepots = new List<Depot>();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RegisterDepot(Depot depot)
    {
        allDepots.Add(depot);
    }

    public Depot GetNearestDepot(Vector3 position)
    {
        float minDis = float.MaxValue;
        Depot rs = null;
        for (int i = 0; i < allDepots.Count; i++)
        {
            float dis = Vector3.Distance(position, allDepots[i].GetPosition());

            if( dis < minDis){
                minDis = dis;
                rs = allDepots[i];
            }
        }
        return rs;
    }
}
