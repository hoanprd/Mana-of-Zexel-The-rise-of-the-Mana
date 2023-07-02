using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFlagZexelTemple : MainFlagGlobal
{
    public GameObject MainFlag1, MainFlag2, MainFlag3;

    // Start is called before the first frame update
    void Start()
    {
        MainFlagGlobal mfd = new MainFlagGlobal();

        mfd.MainFlagDisplay(CutscenesController.cus135, CutscenesController.cus134, MainFlag1);
        mfd.MainFlagDisplay(CutscenesController.cus136, CutscenesController.cus135, MainFlag2);
        mfd.MainFlagDisplay(CutscenesController.cus137, CutscenesController.cus136, MainFlag3);
    }
}
