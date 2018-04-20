using UnityEngine;
using System.Collections;

public class GameSceneMgr{

    private CrystalMgr crystalMgr;

    private BuildingMgr buildingMgr;

    public CrystalMgr GetCrystalMgr() {
        if (crystalMgr == null) {
            crystalMgr = new CrystalMgr();
        }
        return crystalMgr;
    }

    public BuildingMgr GetBuildingMgr() {
        if (buildingMgr == null) {
            buildingMgr = new BuildingMgr();
        }
        return buildingMgr;
    }
}
