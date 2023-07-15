using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagInfernoDesert : MainFlagGlobal
{
    public GameObject MainFlag1, MainFlag2, MainFlag3, MainFlag4;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = FindObjectOfType<MainFlagGlobal>();

        mfd.MainFlagDisplay(CutscenesController.cus37, CutscenesController.cus36, MainFlag1);
        mfd.MainFlagDisplay(CutscenesController.cus38, CutscenesController.cus37, MainFlag2);
        mfd.MainFlagDisplay(CutscenesController.cus50, CutscenesController.cus49, MainFlag3);
        mfd.MainFlagDisplay(CutscenesController.cus95, CutscenesController.cus94, MainFlag4);
        mfd.MainFlagDisplay(CutscenesController.cus105, CutscenesController.cus104, MainFlag4);
        mfd.MainFlagDisplay(CutscenesController.cus123, CutscenesController.cus122, MainFlag4);
        mfd.MainFlagDisplay(CutscenesController.cus126, CutscenesController.cus125, MainFlag4);
    }
}
