using UnityEngine;
using System.Collections;

public class Assert{

	public static void IsTrue(bool value){
        if (value == false) {
            throw new UnityException("Assert(IsTrue) is false!");
        }
    }

    public static void AreEqual(int v1, int v2, string msg){
        if(v1 != v2){
            throw new UnityException("Assert(Are Equal) is false!"+msg);
        }
    }
}
