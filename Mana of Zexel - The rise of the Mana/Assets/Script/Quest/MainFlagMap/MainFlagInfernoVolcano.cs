using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagInfernoVolcano : MainFlagGlobal
{
    public GameObject MainFlag1, MainFlag2, MainFlag3, MainFlag4;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = new MainFlagGlobal();

        mfd.MainFlagDisplay(CutscenesController.cus60, CutscenesController.cus59, MainFlag1);
        mfd.MainFlagDisplay(CutscenesController.cus61, CutscenesController.cus60, MainFlag2);
        mfd.MainFlagDisplay(CutscenesController.cus72, CutscenesController.cus71, MainFlag3);
        mfd.MainFlagDisplay(CutscenesController.cus79, CutscenesController.cus78, MainFlag4);
        mfd.MainFlagDisplay(CutscenesController.cus71, CutscenesController.cus70, MainFlag2);
        mfd.MainFlagDisplay(CutscenesController.cus77, CutscenesController.cus76, MainFlag2);
    }
}
