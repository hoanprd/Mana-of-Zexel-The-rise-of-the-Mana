using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagZexelTown : MainFlagGlobal
{
    public GameObject MainFlag1, MainFlag2, MainFlag3, MainFlag4, MainFlag5, MainFlag6, MainFlag7, MainFlag8;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = FindObjectOfType<MainFlagGlobal>();

        mfd.MainFlagDisplay(CutscenesController.cus4, CutscenesController.cus3, MainFlag1);
        mfd.MainFlagDisplay(CutscenesController.cus9, CutscenesController.cus8, MainFlag2);
        mfd.MainFlagDisplay(CutscenesController.cus9, CutscenesController.cus8, MainFlag3);
        mfd.MainFlagDisplay(CutscenesController.cus9, CutscenesController.cus8, MainFlag4);
        mfd.MainFlagDisplay(CutscenesController.cus10, CutscenesController.cus9, MainFlag5);
        mfd.MainFlagDisplay(CutscenesController.cus28, CutscenesController.cus26, MainFlag6);
        mfd.MainFlagDisplay(CutscenesController.cus33, CutscenesController.cus31, MainFlag7);
        mfd.MainFlagDisplay(CutscenesController.cus34, CutscenesController.cus33, MainFlag8);
    }
}
