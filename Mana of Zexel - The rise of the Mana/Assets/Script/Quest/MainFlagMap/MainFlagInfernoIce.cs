using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagInfernoIce : MainFlagGlobal
{
    public GameObject MainFlag1, MainFlag2, MainFlag3;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = new MainFlagGlobal();

        mfd.MainFlagDisplay(CutscenesController.cus66, CutscenesController.cus65, MainFlag1);
        if (CutscenesController.cus67 == 0 && CutscenesController.cus66 == 1 && CutscenesTrigger.IceFangKill >= 4)
        {
            mfd.MainFlagDisplay(CutscenesController.cus67, CutscenesController.cus66, MainFlag1);
        }
        mfd.MainFlagDisplay(CutscenesController.cus70, CutscenesController.cus69, MainFlag1);
        mfd.MainFlagDisplay(CutscenesController.cus68, CutscenesController.cus67, MainFlag2);
        mfd.MainFlagDisplay(CutscenesController.cus78, CutscenesController.cus77, MainFlag1);
        mfd.MainFlagDisplay(CutscenesController.cus79, CutscenesController.cus78, MainFlag3);
    }
}
