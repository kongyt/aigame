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
}
