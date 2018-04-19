using UnityEngine;
using System.Collections;

public class GameSceneMgr{

    private CrystalMgr crystalMgr;

    public CrystalMgr GetCrystalMgr() {
        if (crystalMgr == null) {
            crystalMgr = new CrystalMgr();
        }
        return crystalMgr;
    }
	
}
